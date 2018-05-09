using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using Microsoft.ProjectOxford.Vision;
using Microsoft.ProjectOxford.Vision.Contract;
using Newtonsoft.Json;

namespace maduka_ComputerVision
{
    public partial class frmMain : Form
    {
        string CompoterVisionApiRootUrl = "[在這裡放上ComputerVision的服務根目錄]" // EX:"https://westus.api.cognitive.microsoft.com/vision/v1.0";
        string CompoterVisionApiKey = "[在這裡放上ComputerVisionKey]";

        string TranslaterUrl = "https://api.microsofttranslator.com/V2/Http.svc/Translate";
        string TranslaterApiKey = "[在這裡放上TranslaterApiKey]";

        VisionServiceClient visionClient;
        FacePanelUtility objFace;

        public frmMain()
        {
            InitializeComponent();
            visionClient = new VisionServiceClient(CompoterVisionApiKey, CompoterVisionApiRootUrl);
            objFace = new FacePanelUtility() { TargetPanel = plImage };
            plImage.Paint += objFace.OnPaint;
        }

        /// <summary>
        /// 開啟圖片對話視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        /// <summary>
        /// 開啟圖片的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.AnalysisImageAsync();
        }

        /// <summary>
        /// 進行圖片辨識的動作
        /// </summary>
        /// <returns></returns>
        private async Task AnalysisImageAsync()
        {
            try
            {
                FileStream fs = File.Open(openFileDialog1.FileName, FileMode.Open);

                // 指定要辨識出的內容有哪些
                VisualFeature[] visualFeatures = new VisualFeature[] {
                    VisualFeature.Color, VisualFeature.Description,
                    VisualFeature.Faces, VisualFeature.Tags };

                // 進行圖片的ComputerVision辨識
                AnalysisResult objResult = await visionClient.AnalyzeImageAsync(fs, visualFeatures);
                fs.Close();

                // 放入分析完之後的JSON內容
                txtComputerVisionResult.Text = JsonConvert.SerializeObject(objResult);

                // 放入說明
                txtCaptions.Text = "";
                for (int i = 0; i < objResult.Description.Captions.Length; i++)
                    txtCaptions.Text += objResult.Description.Captions[i].Text + ".";

                txtImagePath.Text = openFileDialog1.FileName;
                plImage.BackgroundImage = Image.FromFile(openFileDialog1.FileName);

                // 畫出臉的框
                objFace.RenderFaceRectangle(objResult.Faces);
            }
            catch (Exception e)
            {
                string strErrMsg = e.Message;
            }
        }

        /// <summary>
        /// 將結果文字進行翻譯成中文的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTranslator_Click(object sender, EventArgs e)
        {
            string strToLang = "zh-Hant";
            string strText = txtCaptions.Text;
            string strTranslatorUrl = $"{TranslaterUrl}?to={strToLang}&text={strText}";
            List<HeaderObject> objHeaders = new List<HeaderObject>();
            objHeaders.Add(new HeaderObject() { Key = "Ocp-Apim-Subscription-Key", Value = TranslaterApiKey });

            // 呼叫API取得翻譯的結果
            HttpStatusCode code = HttpStatusCode.OK;
            string strResult = this.CallAPI(strTranslatorUrl, "GET", objHeaders, "", out code);
            txtTranslatorResult.Text = strResult;

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(strResult);
            txtTranslatorResult.Text = xmldoc.InnerText;
        }

        /// <summary>
        /// 呼叫API的動作
        /// </summary>
        /// <param name="strUrl"></param>
        /// <param name="strHttpMethod"></param>
        /// <param name="strPostContent"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        protected string CallAPI(string strUrl, string strHttpMethod, List<HeaderObject> objHeaders, string strPostContent, out HttpStatusCode code)
        {
            HttpWebRequest request = HttpWebRequest.Create(strUrl) as HttpWebRequest;
            request.Method = strHttpMethod;
            code = HttpStatusCode.OK;

            for (int i = 0; i < objHeaders.Count; i++)
                request.Headers.Add(objHeaders[i].Key, objHeaders[i].Value);

            if (strPostContent != "" && strPostContent != string.Empty)
            {
                request.KeepAlive = true;
                request.ContentType = "application/json";

                byte[] bs = Encoding.UTF8.GetBytes(strPostContent);
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(bs, 0, bs.Length);
            }

            string strReturn = "";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var respStream = response.GetResponseStream();
                strReturn = new StreamReader(respStream).ReadToEnd();
            }
            catch (Exception e)
            {
                strReturn = e.Message;
                code = HttpStatusCode.NotFound;
            }

            return strReturn;
        }

        public class HeaderObject
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }
    }
}

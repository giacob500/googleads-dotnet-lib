//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by wsdl, Version=1.1.4322.2407.
//
namespace com.google.api.adwords.v13 {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;


    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CampaignServiceSoapBinding", Namespace="https://adwords.google.com/api/adwords/v13")]
    public class CampaignService : System.Web.Services.Protocols.SoapHttpClientProtocol {

        public useragent useragentValue;

        public password passwordValue;

        public email emailValue;

        public clientEmail clientEmailValue;

        public clientCustomerId clientCustomerIdValue;

        public developerToken developerTokenValue;

        public applicationToken applicationTokenValue;

        public responseTime responseTimeValue;

        public operations operationsValue;

        public units unitsValue;

        public requestId requestIdValue;

        /// <remarks/>
        public CampaignService() {
            this.Url = "https://adwords.google.com/api/adwords/v13/CampaignService";
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addCampaignReturn")]
        public Campaign addCampaign(Campaign campaign) {
            object[] results = this.Invoke("addCampaign", new object[] {
                        campaign});
            return ((Campaign)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginaddCampaign(Campaign campaign, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addCampaign", new object[] {
                        campaign}, callback, asyncState);
        }

        /// <remarks/>
        public Campaign EndaddCampaign(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign)(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("addCampaignListReturn")]
        public Campaign[] addCampaignList([System.Xml.Serialization.XmlElementAttribute("campaigns")] Campaign[] campaigns) {
            object[] results = this.Invoke("addCampaignList", new object[] {
                        campaigns});
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginaddCampaignList(Campaign[] campaigns, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("addCampaignList", new object[] {
                        campaigns}, callback, asyncState);
        }

        /// <remarks/>
        public Campaign[] EndaddCampaignList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getActiveAdWordsCampaignsReturn")]
        public Campaign[] getActiveAdWordsCampaigns() {
            object[] results = this.Invoke("getActiveAdWordsCampaigns", new object[0]);
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetActiveAdWordsCampaigns(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getActiveAdWordsCampaigns", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public Campaign[] EndgetActiveAdWordsCampaigns(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAllAdWordsCampaignsReturn")]
        public Campaign[] getAllAdWordsCampaigns(int dummy) {
            object[] results = this.Invoke("getAllAdWordsCampaigns", new object[] {
                        dummy});
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetAllAdWordsCampaigns(int dummy, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAllAdWordsCampaigns", new object[] {
                        dummy}, callback, asyncState);
        }

        /// <remarks/>
        public Campaign[] EndgetAllAdWordsCampaigns(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignReturn")]
        public Campaign getCampaign(int id) {
            object[] results = this.Invoke("getCampaign", new object[] {
                        id});
            return ((Campaign)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetCampaign(int id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaign", new object[] {
                        id}, callback, asyncState);
        }

        /// <remarks/>
        public Campaign EndgetCampaign(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign)(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignListReturn")]
        public Campaign[] getCampaignList([System.Xml.Serialization.XmlElementAttribute("ids")] int[] ids) {
            object[] results = this.Invoke("getCampaignList", new object[] {
                        ids});
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetCampaignList(int[] ids, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaignList", new object[] {
                        ids}, callback, asyncState);
        }

        /// <remarks/>
        public Campaign[] EndgetCampaignList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Campaign[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getCampaignStatsReturn")]
        public StatsRecord[] getCampaignStats([System.Xml.Serialization.XmlElementAttribute("campaignIds")] int[] campaignIds, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime startDay, [System.Xml.Serialization.XmlElementAttribute(DataType="date")] System.DateTime endDay) {
            object[] results = this.Invoke("getCampaignStats", new object[] {
                        campaignIds,
                        startDay,
                        endDay});
            return ((StatsRecord[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetCampaignStats(int[] campaignIds, System.DateTime startDay, System.DateTime endDay, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getCampaignStats", new object[] {
                        campaignIds,
                        startDay,
                        endDay}, callback, asyncState);
        }

        /// <remarks/>
        public StatsRecord[] EndgetCampaignStats(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsRecord[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getConversionOptimizerEligibilityReturn")]
        public ConversionOptimizerEligibility[] getConversionOptimizerEligibility([System.Xml.Serialization.XmlElementAttribute("campaignIds")] int[] campaignIds) {
            object[] results = this.Invoke("getConversionOptimizerEligibility", new object[] {
                        campaignIds});
            return ((ConversionOptimizerEligibility[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetConversionOptimizerEligibility(int[] campaignIds, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getConversionOptimizerEligibility", new object[] {
                        campaignIds}, callback, asyncState);
        }

        /// <remarks/>
        public ConversionOptimizerEligibility[] EndgetConversionOptimizerEligibility(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((ConversionOptimizerEligibility[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getOptimizeAdServingReturn")]
        public bool getOptimizeAdServing(int campaignId) {
            object[] results = this.Invoke("getOptimizeAdServing", new object[] {
                        campaignId});
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetOptimizeAdServing(int campaignId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getOptimizeAdServing", new object[] {
                        campaignId}, callback, asyncState);
        }

        /// <remarks/>
        public bool EndgetOptimizeAdServing(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getRecommendedBudgetListReturn")]
        public CampaignBudget[] getRecommendedBudgetList([System.Xml.Serialization.XmlElementAttribute("campaignIds")] int[] campaignIds) {
            object[] results = this.Invoke("getRecommendedBudgetList", new object[] {
                        campaignIds});
            return ((CampaignBudget[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BegingetRecommendedBudgetList(int[] campaignIds, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getRecommendedBudgetList", new object[] {
                        campaignIds}, callback, asyncState);
        }

        /// <remarks/>
        public CampaignBudget[] EndgetRecommendedBudgetList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((CampaignBudget[])(results[0]));
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setOptimizeAdServing(int campaignId, bool enable) {
            this.Invoke("setOptimizeAdServing", new object[] {
                        campaignId,
                        enable});
        }

        /// <remarks/>
        public System.IAsyncResult BeginsetOptimizeAdServing(int campaignId, bool enable, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("setOptimizeAdServing", new object[] {
                        campaignId,
                        enable}, callback, asyncState);
        }

        /// <remarks/>
        public void EndsetOptimizeAdServing(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateCampaign(Campaign campaign) {
            this.Invoke("updateCampaign", new object[] {
                        campaign});
        }

        /// <remarks/>
        public System.IAsyncResult BeginupdateCampaign(Campaign campaign, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateCampaign", new object[] {
                        campaign}, callback, asyncState);
        }

        /// <remarks/>
        public void EndupdateCampaign(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("unitsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("responseTimeValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientEmailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("applicationTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("clientCustomerIdValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("developerTokenValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("operationsValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("requestIdValue", Direction=System.Web.Services.Protocols.SoapHeaderDirection.Out)]
        [System.Web.Services.Protocols.SoapHeaderAttribute("emailValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("passwordValue")]
        [System.Web.Services.Protocols.SoapHeaderAttribute("useragentValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="https://adwords.google.com/api/adwords/v13", ResponseNamespace="https://adwords.google.com/api/adwords/v13", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void updateCampaignList([System.Xml.Serialization.XmlElementAttribute("campaigns")] Campaign[] campaigns) {
            this.Invoke("updateCampaignList", new object[] {
                        campaigns});
        }

        /// <remarks/>
        public System.IAsyncResult BeginupdateCampaignList(Campaign[] campaigns, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updateCampaignList", new object[] {
                        campaigns}, callback, asyncState);
        }

        /// <remarks/>
        public void EndupdateCampaignList(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class Campaign {

        /// <remarks/>
        public long budgetAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool budgetAmountSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public BudgetOptimizerSettings budgetOptimizerSettings;

        /// <remarks/>
        public BudgetPeriod budgetPeriod;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool budgetPeriodSpecified;

        /// <remarks/>
        public ContentTargeting contentTargeting;

        /// <remarks/>
        public ConversionOptimizerSettings conversionOptimizerSettings;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime endDay;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endDaySpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public GeoTarget geoTargeting;

        /// <remarks/>
        public int id;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("languages")]
        public string[] languageTargeting;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string name;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("networkTypes", IsNullable=false)]
        public NetworkType[] networkTargeting;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public AdSchedule schedule;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime startDay;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startDaySpecified;

        /// <remarks/>
        public CampaignStatus status;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class BudgetOptimizerSettings {

        /// <remarks/>
        public long bidCeiling;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bidCeilingSpecified;

        /// <remarks/>
        public bool enabled;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enabledSpecified;

        /// <remarks/>
        public bool takeOnOptimizedBids;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool takeOnOptimizedBidsSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class CampaignBudget {

        /// <remarks/>
        public long budgetAmount;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool budgetAmountSpecified;

        /// <remarks/>
        public BudgetPeriod budgetPeriod;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool budgetPeriodSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public enum BudgetPeriod {

        /// <remarks/>
        Daily,

        /// <remarks/>
        Monthly,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class ConversionOptimizerEligibility {

        /// <remarks/>
        public int campaignId;

        /// <remarks/>
        public bool eligibleToSwitchOn;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligibleToSwitchOnSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class SchedulingInterval {

        /// <remarks/>
        public DayOfWeek day;

        /// <remarks/>
        public int endHour;

        /// <remarks/>
        public int endMinute;

        /// <remarks/>
        public System.Double multiplier;

        /// <remarks/>
        public int startHour;

        /// <remarks/>
        public int startMinute;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public enum DayOfWeek {

        /// <remarks/>
        Monday,

        /// <remarks/>
        Tuesday,

        /// <remarks/>
        Wednesday,

        /// <remarks/>
        Thursday,

        /// <remarks/>
        Friday,

        /// <remarks/>
        Saturday,

        /// <remarks/>
        Sunday,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class AdSchedule {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("intervals")]
        public SchedulingInterval[] intervals;

        /// <remarks/>
        public AdScheduleStatus status;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public enum AdScheduleStatus {

        /// <remarks/>
        Disabled,

        /// <remarks/>
        Enabled,
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public class ConversionOptimizerSettings {

        /// <remarks/>
        public bool enabled;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool enabledSpecified;

        /// <remarks/>
        public long maxCpaBidForAllAdGroups;

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxCpaBidForAllAdGroupsSpecified;
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public enum ContentTargeting {

        /// <remarks/>
        AllPlacements,

        /// <remarks/>
        SelectedPlacements,
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://adwords.google.com/api/adwords/v13")]
    public enum CampaignStatus {

        /// <remarks/>
        Active,

        /// <remarks/>
        Pending,

        /// <remarks/>
        Ended,

        /// <remarks/>
        Paused,

        /// <remarks/>
        Deleted,

        /// <remarks/>
        Suspended,
    }
}

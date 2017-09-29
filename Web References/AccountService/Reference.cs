﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace CostErrDeal.AccountService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AccountServiceSoap", Namespace="http://tempuri.org/CostAccountWS")]
    public partial class AccountService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendMessageFromLogistic_ALLOperationCompleted;
        
        private System.Threading.SendOrPostCallback DelMessageFromFI_ALLOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAccountNo_TIPTOPOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAccountStatus_TIPTOPOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AccountService() {
            this.Url = global::CostErrDeal.Properties.Settings.Default.CostErrDeal_AccountService_AccountService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SendMessageFromLogistic_ALLCompletedEventHandler SendMessageFromLogistic_ALLCompleted;
        
        /// <remarks/>
        public event DelMessageFromFI_ALLCompletedEventHandler DelMessageFromFI_ALLCompleted;
        
        /// <remarks/>
        public event GetAccountNo_TIPTOPCompletedEventHandler GetAccountNo_TIPTOPCompleted;
        
        /// <remarks/>
        public event GetAccountStatus_TIPTOPCompletedEventHandler GetAccountStatus_TIPTOPCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CostAccountWS/SendMessageFromLogistic_ALL", RequestNamespace="http://tempuri.org/CostAccountWS", ResponseNamespace="http://tempuri.org/CostAccountWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendMessageFromLogistic_ALL(string eal01) {
            object[] results = this.Invoke("SendMessageFromLogistic_ALL", new object[] {
                        eal01});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendMessageFromLogistic_ALLAsync(string eal01) {
            this.SendMessageFromLogistic_ALLAsync(eal01, null);
        }
        
        /// <remarks/>
        public void SendMessageFromLogistic_ALLAsync(string eal01, object userState) {
            if ((this.SendMessageFromLogistic_ALLOperationCompleted == null)) {
                this.SendMessageFromLogistic_ALLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMessageFromLogistic_ALLOperationCompleted);
            }
            this.InvokeAsync("SendMessageFromLogistic_ALL", new object[] {
                        eal01}, this.SendMessageFromLogistic_ALLOperationCompleted, userState);
        }
        
        private void OnSendMessageFromLogistic_ALLOperationCompleted(object arg) {
            if ((this.SendMessageFromLogistic_ALLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendMessageFromLogistic_ALLCompleted(this, new SendMessageFromLogistic_ALLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CostAccountWS/DelMessageFromFI_ALL", RequestNamespace="http://tempuri.org/CostAccountWS", ResponseNamespace="http://tempuri.org/CostAccountWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DelMessageFromFI_ALL(string eal01) {
            object[] results = this.Invoke("DelMessageFromFI_ALL", new object[] {
                        eal01});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DelMessageFromFI_ALLAsync(string eal01) {
            this.DelMessageFromFI_ALLAsync(eal01, null);
        }
        
        /// <remarks/>
        public void DelMessageFromFI_ALLAsync(string eal01, object userState) {
            if ((this.DelMessageFromFI_ALLOperationCompleted == null)) {
                this.DelMessageFromFI_ALLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDelMessageFromFI_ALLOperationCompleted);
            }
            this.InvokeAsync("DelMessageFromFI_ALL", new object[] {
                        eal01}, this.DelMessageFromFI_ALLOperationCompleted, userState);
        }
        
        private void OnDelMessageFromFI_ALLOperationCompleted(object arg) {
            if ((this.DelMessageFromFI_ALLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DelMessageFromFI_ALLCompleted(this, new DelMessageFromFI_ALLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CostAccountWS/GetAccountNo_TIPTOP", RequestNamespace="http://tempuri.org/CostAccountWS", ResponseNamespace="http://tempuri.org/CostAccountWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAccountNo_TIPTOP(string eal01) {
            object[] results = this.Invoke("GetAccountNo_TIPTOP", new object[] {
                        eal01});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountNo_TIPTOPAsync(string eal01) {
            this.GetAccountNo_TIPTOPAsync(eal01, null);
        }
        
        /// <remarks/>
        public void GetAccountNo_TIPTOPAsync(string eal01, object userState) {
            if ((this.GetAccountNo_TIPTOPOperationCompleted == null)) {
                this.GetAccountNo_TIPTOPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountNo_TIPTOPOperationCompleted);
            }
            this.InvokeAsync("GetAccountNo_TIPTOP", new object[] {
                        eal01}, this.GetAccountNo_TIPTOPOperationCompleted, userState);
        }
        
        private void OnGetAccountNo_TIPTOPOperationCompleted(object arg) {
            if ((this.GetAccountNo_TIPTOPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountNo_TIPTOPCompleted(this, new GetAccountNo_TIPTOPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CostAccountWS/GetAccountStatus_TIPTOP", RequestNamespace="http://tempuri.org/CostAccountWS", ResponseNamespace="http://tempuri.org/CostAccountWS", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAccountStatus_TIPTOP(string eal01) {
            object[] results = this.Invoke("GetAccountStatus_TIPTOP", new object[] {
                        eal01});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountStatus_TIPTOPAsync(string eal01) {
            this.GetAccountStatus_TIPTOPAsync(eal01, null);
        }
        
        /// <remarks/>
        public void GetAccountStatus_TIPTOPAsync(string eal01, object userState) {
            if ((this.GetAccountStatus_TIPTOPOperationCompleted == null)) {
                this.GetAccountStatus_TIPTOPOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountStatus_TIPTOPOperationCompleted);
            }
            this.InvokeAsync("GetAccountStatus_TIPTOP", new object[] {
                        eal01}, this.GetAccountStatus_TIPTOPOperationCompleted, userState);
        }
        
        private void OnGetAccountStatus_TIPTOPOperationCompleted(object arg) {
            if ((this.GetAccountStatus_TIPTOPCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountStatus_TIPTOPCompleted(this, new GetAccountStatus_TIPTOPCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void SendMessageFromLogistic_ALLCompletedEventHandler(object sender, SendMessageFromLogistic_ALLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendMessageFromLogistic_ALLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendMessageFromLogistic_ALLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void DelMessageFromFI_ALLCompletedEventHandler(object sender, DelMessageFromFI_ALLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DelMessageFromFI_ALLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DelMessageFromFI_ALLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void GetAccountNo_TIPTOPCompletedEventHandler(object sender, GetAccountNo_TIPTOPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountNo_TIPTOPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountNo_TIPTOPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void GetAccountStatus_TIPTOPCompletedEventHandler(object sender, GetAccountStatus_TIPTOPCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountStatus_TIPTOPCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountStatus_TIPTOPCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
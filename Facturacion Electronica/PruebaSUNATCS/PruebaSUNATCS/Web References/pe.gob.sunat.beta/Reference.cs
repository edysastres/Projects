﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PruebaSUNATCS.pe.gob.sunat.beta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BillServicePortBinding", Namespace="http://service.gem.factura.comppago.registro.servicio.sunat.gob.pe/")]
    public partial class billService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendBillOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendPackOperationCompleted;
        
        private System.Threading.SendOrPostCallback sendSummaryOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public billService() {
            this.Url = global::PruebaSUNATCS.Properties.Settings.Default.PruebaSUNATCS_pe_gob_sunat_beta_billService;
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
        public event getStatusCompletedEventHandler getStatusCompleted;
        
        /// <remarks/>
        public event sendBillCompletedEventHandler sendBillCompleted;
        
        /// <remarks/>
        public event sendPackCompletedEventHandler sendPackCompleted;
        
        /// <remarks/>
        public event sendSummaryCompletedEventHandler sendSummaryCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getStatus", RequestNamespace="http://service.sunat.gob.pe", ResponseNamespace="http://service.sunat.gob.pe", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("status", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public statusResponse getStatus([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string ticket) {
            object[] results = this.Invoke("getStatus", new object[] {
                        ticket});
            return ((statusResponse)(results[0]));
        }
        
        /// <remarks/>
        public void getStatusAsync(string ticket) {
            this.getStatusAsync(ticket, null);
        }
        
        /// <remarks/>
        public void getStatusAsync(string ticket, object userState) {
            if ((this.getStatusOperationCompleted == null)) {
                this.getStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetStatusOperationCompleted);
            }
            this.InvokeAsync("getStatus", new object[] {
                        ticket}, this.getStatusOperationCompleted, userState);
        }
        
        private void OngetStatusOperationCompleted(object arg) {
            if ((this.getStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getStatusCompleted(this, new getStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendBill", RequestNamespace="http://service.sunat.gob.pe", ResponseNamespace="http://service.sunat.gob.pe", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("applicationResponse", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] sendBill([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string fileName, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")] byte[] contentFile, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string partyType) {
            object[] results = this.Invoke("sendBill", new object[] {
                        fileName,
                        contentFile,
                        partyType});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void sendBillAsync(string fileName, byte[] contentFile, string partyType) {
            this.sendBillAsync(fileName, contentFile, partyType, null);
        }
        
        /// <remarks/>
        public void sendBillAsync(string fileName, byte[] contentFile, string partyType, object userState) {
            if ((this.sendBillOperationCompleted == null)) {
                this.sendBillOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendBillOperationCompleted);
            }
            this.InvokeAsync("sendBill", new object[] {
                        fileName,
                        contentFile,
                        partyType}, this.sendBillOperationCompleted, userState);
        }
        
        private void OnsendBillOperationCompleted(object arg) {
            if ((this.sendBillCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendBillCompleted(this, new sendBillCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendPack", RequestNamespace="http://service.sunat.gob.pe", ResponseNamespace="http://service.sunat.gob.pe", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ticket", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sendPack([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string fileName, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")] byte[] contentFile, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string partyType) {
            object[] results = this.Invoke("sendPack", new object[] {
                        fileName,
                        contentFile,
                        partyType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sendPackAsync(string fileName, byte[] contentFile, string partyType) {
            this.sendPackAsync(fileName, contentFile, partyType, null);
        }
        
        /// <remarks/>
        public void sendPackAsync(string fileName, byte[] contentFile, string partyType, object userState) {
            if ((this.sendPackOperationCompleted == null)) {
                this.sendPackOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendPackOperationCompleted);
            }
            this.InvokeAsync("sendPack", new object[] {
                        fileName,
                        contentFile,
                        partyType}, this.sendPackOperationCompleted, userState);
        }
        
        private void OnsendPackOperationCompleted(object arg) {
            if ((this.sendPackCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendPackCompleted(this, new sendPackCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sendSummary", RequestNamespace="http://service.sunat.gob.pe", ResponseNamespace="http://service.sunat.gob.pe", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("ticket", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string sendSummary([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string fileName, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")] byte[] contentFile, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string partyType) {
            object[] results = this.Invoke("sendSummary", new object[] {
                        fileName,
                        contentFile,
                        partyType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void sendSummaryAsync(string fileName, byte[] contentFile, string partyType) {
            this.sendSummaryAsync(fileName, contentFile, partyType, null);
        }
        
        /// <remarks/>
        public void sendSummaryAsync(string fileName, byte[] contentFile, string partyType, object userState) {
            if ((this.sendSummaryOperationCompleted == null)) {
                this.sendSummaryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsendSummaryOperationCompleted);
            }
            this.InvokeAsync("sendSummary", new object[] {
                        fileName,
                        contentFile,
                        partyType}, this.sendSummaryOperationCompleted, userState);
        }
        
        private void OnsendSummaryOperationCompleted(object arg) {
            if ((this.sendSummaryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.sendSummaryCompleted(this, new sendSummaryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getStatusCompletedEventHandler(object sender, getStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public statusResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((statusResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void sendBillCompletedEventHandler(object sender, sendBillCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendBillCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendBillCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void sendPackCompletedEventHandler(object sender, sendPackCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendPackCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendPackCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void sendSummaryCompletedEventHandler(object sender, sendSummaryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sendSummaryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal sendSummaryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
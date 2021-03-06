﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DayBuyDay.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Products", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Products : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ASMXWebServiceSoap")]
    public interface ASMXWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetProductsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProducts", ReplyAction="*")]
        DayBuyDay.ServiceReference.GetProductsResponse GetProducts(DayBuyDay.ServiceReference.GetProductsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetProducts", ReplyAction="*")]
        System.Threading.Tasks.Task<DayBuyDay.ServiceReference.GetProductsResponse> GetProductsAsync(DayBuyDay.ServiceReference.GetProductsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProducts", Namespace="http://tempuri.org/", Order=0)]
        public DayBuyDay.ServiceReference.GetProductsRequestBody Body;
        
        public GetProductsRequest() {
        }
        
        public GetProductsRequest(DayBuyDay.ServiceReference.GetProductsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetProductsRequestBody {
        
        public GetProductsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsResponse", Namespace="http://tempuri.org/", Order=0)]
        public DayBuyDay.ServiceReference.GetProductsResponseBody Body;
        
        public GetProductsResponse() {
        }
        
        public GetProductsResponse(DayBuyDay.ServiceReference.GetProductsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DayBuyDay.ServiceReference.Products[] GetProductsResult;
        
        public GetProductsResponseBody() {
        }
        
        public GetProductsResponseBody(DayBuyDay.ServiceReference.Products[] GetProductsResult) {
            this.GetProductsResult = GetProductsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ASMXWebServiceSoapChannel : DayBuyDay.ServiceReference.ASMXWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ASMXWebServiceSoapClient : System.ServiceModel.ClientBase<DayBuyDay.ServiceReference.ASMXWebServiceSoap>, DayBuyDay.ServiceReference.ASMXWebServiceSoap {
        
        public ASMXWebServiceSoapClient() {
        }
        
        public ASMXWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ASMXWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ASMXWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ASMXWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DayBuyDay.ServiceReference.GetProductsResponse DayBuyDay.ServiceReference.ASMXWebServiceSoap.GetProducts(DayBuyDay.ServiceReference.GetProductsRequest request) {
            return base.Channel.GetProducts(request);
        }
        
        public DayBuyDay.ServiceReference.Products[] GetProducts() {
            DayBuyDay.ServiceReference.GetProductsRequest inValue = new DayBuyDay.ServiceReference.GetProductsRequest();
            inValue.Body = new DayBuyDay.ServiceReference.GetProductsRequestBody();
            DayBuyDay.ServiceReference.GetProductsResponse retVal = ((DayBuyDay.ServiceReference.ASMXWebServiceSoap)(this)).GetProducts(inValue);
            return retVal.Body.GetProductsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DayBuyDay.ServiceReference.GetProductsResponse> DayBuyDay.ServiceReference.ASMXWebServiceSoap.GetProductsAsync(DayBuyDay.ServiceReference.GetProductsRequest request) {
            return base.Channel.GetProductsAsync(request);
        }
        
        public System.Threading.Tasks.Task<DayBuyDay.ServiceReference.GetProductsResponse> GetProductsAsync() {
            DayBuyDay.ServiceReference.GetProductsRequest inValue = new DayBuyDay.ServiceReference.GetProductsRequest();
            inValue.Body = new DayBuyDay.ServiceReference.GetProductsRequestBody();
            return ((DayBuyDay.ServiceReference.ASMXWebServiceSoap)(this)).GetProductsAsync(inValue);
        }
    }
}

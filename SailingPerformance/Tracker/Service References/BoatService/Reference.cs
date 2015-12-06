﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tracker.BoatService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BoatRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Services.BoatService")]
    [System.SerializableAttribute()]
    public partial class BoatRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdBoatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid IdBoat {
            get {
                return this.IdBoatField;
            }
            set {
                if ((this.IdBoatField.Equals(value) != true)) {
                    this.IdBoatField = value;
                    this.RaisePropertyChanged("IdBoat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Tracker.BoatService.GetBoatResponse))]
    public partial class BaseResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetBoatResponse", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Services.BoatService")]
    [System.SerializableAttribute()]
    public partial class GetBoatResponse : Tracker.BoatService.BaseResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteBoatRequest", Namespace="http://schemas.datacontract.org/2004/07/WcfService.Services.BoatService")]
    [System.SerializableAttribute()]
    public partial class DeleteBoatRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BoatService.IBoatService")]
    public interface IBoatService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/AddBoat", ReplyAction="http://tempuri.org/IBoatService/AddBoatResponse")]
        Tracker.BoatService.BaseResponse AddBoat(Tracker.BoatService.BoatRequest boatRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/AddBoat", ReplyAction="http://tempuri.org/IBoatService/AddBoatResponse")]
        System.Threading.Tasks.Task<Tracker.BoatService.BaseResponse> AddBoatAsync(Tracker.BoatService.BoatRequest boatRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/UpdateBoat", ReplyAction="http://tempuri.org/IBoatService/UpdateBoatResponse")]
        Tracker.BoatService.BaseResponse UpdateBoat(Tracker.BoatService.BoatRequest boatRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/UpdateBoat", ReplyAction="http://tempuri.org/IBoatService/UpdateBoatResponse")]
        System.Threading.Tasks.Task<Tracker.BoatService.BaseResponse> UpdateBoatAsync(Tracker.BoatService.BoatRequest boatRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/DeleteBoat", ReplyAction="http://tempuri.org/IBoatService/DeleteBoatResponse")]
        Tracker.BoatService.BaseResponse DeleteBoat(Tracker.BoatService.DeleteBoatRequest id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/DeleteBoat", ReplyAction="http://tempuri.org/IBoatService/DeleteBoatResponse")]
        System.Threading.Tasks.Task<Tracker.BoatService.BaseResponse> DeleteBoatAsync(Tracker.BoatService.DeleteBoatRequest id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/GetBoatId", ReplyAction="http://tempuri.org/IBoatService/GetBoatIdResponse")]
        Tracker.BoatService.GetBoatResponse GetBoatId(Tracker.BoatService.BoatRequest boatRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBoatService/GetBoatId", ReplyAction="http://tempuri.org/IBoatService/GetBoatIdResponse")]
        System.Threading.Tasks.Task<Tracker.BoatService.GetBoatResponse> GetBoatIdAsync(Tracker.BoatService.BoatRequest boatRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBoatServiceChannel : Tracker.BoatService.IBoatService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BoatServiceClient : System.ServiceModel.ClientBase<Tracker.BoatService.IBoatService>, Tracker.BoatService.IBoatService {
        
        public BoatServiceClient() {
        }
        
        public BoatServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BoatServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoatServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoatServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Tracker.BoatService.BaseResponse AddBoat(Tracker.BoatService.BoatRequest boatRequest) {
            return base.Channel.AddBoat(boatRequest);
        }
        
        public System.Threading.Tasks.Task<Tracker.BoatService.BaseResponse> AddBoatAsync(Tracker.BoatService.BoatRequest boatRequest) {
            return base.Channel.AddBoatAsync(boatRequest);
        }
        
        public Tracker.BoatService.BaseResponse UpdateBoat(Tracker.BoatService.BoatRequest boatRequest) {
            return base.Channel.UpdateBoat(boatRequest);
        }
        
        public System.Threading.Tasks.Task<Tracker.BoatService.BaseResponse> UpdateBoatAsync(Tracker.BoatService.BoatRequest boatRequest) {
            return base.Channel.UpdateBoatAsync(boatRequest);
        }
        
        public Tracker.BoatService.BaseResponse DeleteBoat(Tracker.BoatService.DeleteBoatRequest id) {
            return base.Channel.DeleteBoat(id);
        }
        
        public System.Threading.Tasks.Task<Tracker.BoatService.BaseResponse> DeleteBoatAsync(Tracker.BoatService.DeleteBoatRequest id) {
            return base.Channel.DeleteBoatAsync(id);
        }
        
        public Tracker.BoatService.GetBoatResponse GetBoatId(Tracker.BoatService.BoatRequest boatRequest) {
            return base.Channel.GetBoatId(boatRequest);
        }
        
        public System.Threading.Tasks.Task<Tracker.BoatService.GetBoatResponse> GetBoatIdAsync(Tracker.BoatService.BoatRequest boatRequest) {
            return base.Channel.GetBoatIdAsync(boatRequest);
        }
    }
}

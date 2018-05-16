﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp.INGService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/INGServer.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string first_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_userField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string last_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public string first_name {
            get {
                return this.first_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.first_nameField, value) != true)) {
                    this.first_nameField = value;
                    this.RaisePropertyChanged("first_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_user {
            get {
                return this.id_userField;
            }
            set {
                if ((this.id_userField.Equals(value) != true)) {
                    this.id_userField = value;
                    this.RaisePropertyChanged("id_user");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string last_name {
            get {
                return this.last_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.last_nameField, value) != true)) {
                    this.last_nameField = value;
                    this.RaisePropertyChanged("last_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="INGService.IINGService")]
    public interface IINGService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IINGService/AddUser", ReplyAction="http://tempuri.org/IINGService/AddUserResponse")]
        void AddUser(WpfApp.INGService.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IINGService/AddUser", ReplyAction="http://tempuri.org/IINGService/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(WpfApp.INGService.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IINGServiceChannel : WpfApp.INGService.IINGService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class INGServiceClient : System.ServiceModel.ClientBase<WpfApp.INGService.IINGService>, WpfApp.INGService.IINGService {
        
        public INGServiceClient() {
        }
        
        public INGServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public INGServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public INGServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public INGServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUser(WpfApp.INGService.User user) {
            base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(WpfApp.INGService.User user) {
            return base.Channel.AddUserAsync(user);
        }
    }
}
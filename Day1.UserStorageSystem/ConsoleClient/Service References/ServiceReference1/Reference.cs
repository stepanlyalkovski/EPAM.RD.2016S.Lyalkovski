﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Task1.StorageSystem.Entities")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime BirthDatek__BackingFieldField;
        
        private string FirstNamek__BackingFieldField;
        
        private ConsoleClient.ServiceReference1.Gender Genderk__BackingFieldField;
        
        private int Idk__BackingFieldField;
        
        private string LastNamek__BackingFieldField;
        
        private string PersonalIdk__BackingFieldField;
        
        private ConsoleClient.ServiceReference1.VisaRecord[] VisaRecordsk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<BirthDate>k__BackingField", IsRequired=true)]
        public System.DateTime BirthDatek__BackingField {
            get {
                return this.BirthDatek__BackingFieldField;
            }
            set {
                if ((this.BirthDatek__BackingFieldField.Equals(value) != true)) {
                    this.BirthDatek__BackingFieldField = value;
                    this.RaisePropertyChanged("BirthDatek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<FirstName>k__BackingField", IsRequired=true)]
        public string FirstNamek__BackingField {
            get {
                return this.FirstNamek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNamek__BackingFieldField, value) != true)) {
                    this.FirstNamek__BackingFieldField = value;
                    this.RaisePropertyChanged("FirstNamek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Gender>k__BackingField", IsRequired=true)]
        public ConsoleClient.ServiceReference1.Gender Genderk__BackingField {
            get {
                return this.Genderk__BackingFieldField;
            }
            set {
                if ((this.Genderk__BackingFieldField.Equals(value) != true)) {
                    this.Genderk__BackingFieldField = value;
                    this.RaisePropertyChanged("Genderk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Id>k__BackingField", IsRequired=true)]
        public int Idk__BackingField {
            get {
                return this.Idk__BackingFieldField;
            }
            set {
                if ((this.Idk__BackingFieldField.Equals(value) != true)) {
                    this.Idk__BackingFieldField = value;
                    this.RaisePropertyChanged("Idk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<LastName>k__BackingField", IsRequired=true)]
        public string LastNamek__BackingField {
            get {
                return this.LastNamek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNamek__BackingFieldField, value) != true)) {
                    this.LastNamek__BackingFieldField = value;
                    this.RaisePropertyChanged("LastNamek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<PersonalId>k__BackingField", IsRequired=true)]
        public string PersonalIdk__BackingField {
            get {
                return this.PersonalIdk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonalIdk__BackingFieldField, value) != true)) {
                    this.PersonalIdk__BackingFieldField = value;
                    this.RaisePropertyChanged("PersonalIdk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<VisaRecords>k__BackingField", IsRequired=true)]
        public ConsoleClient.ServiceReference1.VisaRecord[] VisaRecordsk__BackingField {
            get {
                return this.VisaRecordsk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.VisaRecordsk__BackingFieldField, value) != true)) {
                    this.VisaRecordsk__BackingFieldField = value;
                    this.RaisePropertyChanged("VisaRecordsk__BackingField");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://schemas.datacontract.org/2004/07/Task1.StorageSystem.Entities")]
    public enum Gender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VisaRecord", Namespace="http://schemas.datacontract.org/2004/07/Task1.StorageSystem.Entities")]
    [System.SerializableAttribute()]
    public partial struct VisaRecord : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Countryk__BackingFieldField;
        
        private System.DateTime EndDatek__BackingFieldField;
        
        private System.DateTime StartDatek__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Country>k__BackingField", IsRequired=true)]
        public string Countryk__BackingField {
            get {
                return this.Countryk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Countryk__BackingFieldField, value) != true)) {
                    this.Countryk__BackingFieldField = value;
                    this.RaisePropertyChanged("Countryk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<EndDate>k__BackingField", IsRequired=true)]
        public System.DateTime EndDatek__BackingField {
            get {
                return this.EndDatek__BackingFieldField;
            }
            set {
                if ((this.EndDatek__BackingFieldField.Equals(value) != true)) {
                    this.EndDatek__BackingFieldField = value;
                    this.RaisePropertyChanged("EndDatek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<StartDate>k__BackingField", IsRequired=true)]
        public System.DateTime StartDatek__BackingField {
            get {
                return this.StartDatek__BackingFieldField;
            }
            set {
                if ((this.StartDatek__BackingFieldField.Equals(value) != true)) {
                    this.StartDatek__BackingFieldField = value;
                    this.RaisePropertyChanged("StartDatek__BackingField");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CriterionFemales", Namespace="http://schemas.datacontract.org/2004/07/Task1.StorageSystem.Concrete.SearchCriter" +
        "ies.UserCriteries")]
    [System.SerializableAttribute()]
    public partial class CriterionFemales : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CriterionMales", Namespace="http://schemas.datacontract.org/2004/07/Task1.StorageSystem.Concrete.SearchCriter" +
        "ies.UserCriteries")]
    [System.SerializableAttribute()]
    public partial class CriterionMales : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CriterionPersonalId", Namespace="http://schemas.datacontract.org/2004/07/Task1.StorageSystem.Concrete.SearchCriter" +
        "ies.UserCriteries")]
    [System.SerializableAttribute()]
    public partial class CriterionPersonalId : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IUserServiceContract")]
    public interface IUserServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Add", ReplyAction="http://tempuri.org/IUserServiceContract/AddResponse")]
        int Add(ConsoleClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Add", ReplyAction="http://tempuri.org/IUserServiceContract/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(ConsoleClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Delete", ReplyAction="http://tempuri.org/IUserServiceContract/DeleteResponse")]
        void Delete(ConsoleClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Delete", ReplyAction="http://tempuri.org/IUserServiceContract/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(ConsoleClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Save", ReplyAction="http://tempuri.org/IUserServiceContract/SaveResponse")]
        void Save();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Save", ReplyAction="http://tempuri.org/IUserServiceContract/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Initialize", ReplyAction="http://tempuri.org/IUserServiceContract/InitializeResponse")]
        void Initialize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/Initialize", ReplyAction="http://tempuri.org/IUserServiceContract/InitializeResponse")]
        System.Threading.Tasks.Task InitializeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/SearchForUsers", ReplyAction="http://tempuri.org/IUserServiceContract/SearchForUsersResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.User))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.Gender))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.VisaRecord[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.VisaRecord))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(int[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.CriterionFemales))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.CriterionMales))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleClient.ServiceReference1.CriterionPersonalId))]
        int[] SearchForUsers(object[] criteries);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceContract/SearchForUsers", ReplyAction="http://tempuri.org/IUserServiceContract/SearchForUsersResponse")]
        System.Threading.Tasks.Task<int[]> SearchForUsersAsync(object[] criteries);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceContractChannel : ConsoleClient.ServiceReference1.IUserServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceContractClient : System.ServiceModel.ClientBase<ConsoleClient.ServiceReference1.IUserServiceContract>, ConsoleClient.ServiceReference1.IUserServiceContract {
        
        public UserServiceContractClient() {
        }
        
        public UserServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(ConsoleClient.ServiceReference1.User user) {
            return base.Channel.Add(user);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(ConsoleClient.ServiceReference1.User user) {
            return base.Channel.AddAsync(user);
        }
        
        public void Delete(ConsoleClient.ServiceReference1.User user) {
            base.Channel.Delete(user);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(ConsoleClient.ServiceReference1.User user) {
            return base.Channel.DeleteAsync(user);
        }
        
        public void Save() {
            base.Channel.Save();
        }
        
        public System.Threading.Tasks.Task SaveAsync() {
            return base.Channel.SaveAsync();
        }
        
        public void Initialize() {
            base.Channel.Initialize();
        }
        
        public System.Threading.Tasks.Task InitializeAsync() {
            return base.Channel.InitializeAsync();
        }
        
        public int[] SearchForUsers(object[] criteries) {
            return base.Channel.SearchForUsers(criteries);
        }
        
        public System.Threading.Tasks.Task<int[]> SearchForUsersAsync(object[] criteries) {
            return base.Channel.SearchForUsersAsync(criteries);
        }
    }
}
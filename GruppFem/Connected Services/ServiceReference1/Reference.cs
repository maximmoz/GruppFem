﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GruppFem.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/GruppFemWCF")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FName {
            get {
                return this.FNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FNameField, value) != true)) {
                    this.FNameField = value;
                    this.RaisePropertyChanged("FName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LName {
            get {
                return this.LNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LNameField, value) != true)) {
                    this.LNameField = value;
                    this.RaisePropertyChanged("LName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EstablishmentInfo", Namespace="http://schemas.datacontract.org/2004/07/GruppFemWCF")]
    [System.SerializableAttribute()]
    public partial class EstablishmentInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] EstablishmentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] URatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserRatingField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] EstablishmentID {
            get {
                return this.EstablishmentIDField;
            }
            set {
                if ((object.ReferenceEquals(this.EstablishmentIDField, value) != true)) {
                    this.EstablishmentIDField = value;
                    this.RaisePropertyChanged("EstablishmentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] URating {
            get {
                return this.URatingField;
            }
            set {
                if ((object.ReferenceEquals(this.URatingField, value) != true)) {
                    this.URatingField = value;
                    this.RaisePropertyChanged("URating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIDField, value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserRating {
            get {
                return this.UserRatingField;
            }
            set {
                if ((this.UserRatingField.Equals(value) != true)) {
                    this.UserRatingField = value;
                    this.RaisePropertyChanged("UserRating");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserInfo", ReplyAction="http://tempuri.org/IService1/GetUserInfoResponse")]
        GruppFem.ServiceReference1.UserInfo[] GetUserInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserInfo", ReplyAction="http://tempuri.org/IService1/GetUserInfoResponse")]
        System.Threading.Tasks.Task<GruppFem.ServiceReference1.UserInfo[]> GetUserInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEstablishmentInfo", ReplyAction="http://tempuri.org/IService1/GetEstablishmentInfoResponse")]
        GruppFem.ServiceReference1.EstablishmentInfo[] GetEstablishmentInfo(System.Nullable<int> userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEstablishmentInfo", ReplyAction="http://tempuri.org/IService1/GetEstablishmentInfoResponse")]
        System.Threading.Tasks.Task<GruppFem.ServiceReference1.EstablishmentInfo[]> GetEstablishmentInfoAsync(System.Nullable<int> userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        void DeleteUser(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        void CreateUser(string username, string password, string firstname, string lastname, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateUser", ReplyAction="http://tempuri.org/IService1/CreateUserResponse")]
        System.Threading.Tasks.Task CreateUserAsync(string username, string password, string firstname, string lastname, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        void UpdateUser(int userID, string username, string password, string firstname, string lastname, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(int userID, string username, string password, string firstname, string lastname, string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEstablishment", ReplyAction="http://tempuri.org/IService1/UpdateEstablishmentResponse")]
        void UpdateEstablishment(int establishmentID, int rating, int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEstablishment", ReplyAction="http://tempuri.org/IService1/UpdateEstablishmentResponse")]
        System.Threading.Tasks.Task UpdateEstablishmentAsync(int establishmentID, int rating, int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoginUser", ReplyAction="http://tempuri.org/IService1/LoginUserResponse")]
        bool LoginUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoginUser", ReplyAction="http://tempuri.org/IService1/LoginUserResponse")]
        System.Threading.Tasks.Task<bool> LoginUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserID", ReplyAction="http://tempuri.org/IService1/GetUserIDResponse")]
        int GetUserID(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserID", ReplyAction="http://tempuri.org/IService1/GetUserIDResponse")]
        System.Threading.Tasks.Task<int> GetUserIDAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEstablishments", ReplyAction="http://tempuri.org/IService1/GetEstablishmentsResponse")]
        GruppFem.ServiceReference1.EstablishmentInfo[] GetEstablishments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEstablishments", ReplyAction="http://tempuri.org/IService1/GetEstablishmentsResponse")]
        System.Threading.Tasks.Task<GruppFem.ServiceReference1.EstablishmentInfo[]> GetEstablishmentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsername", ReplyAction="http://tempuri.org/IService1/GetUsernameResponse")]
        string GetUsername(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsername", ReplyAction="http://tempuri.org/IService1/GetUsernameResponse")]
        System.Threading.Tasks.Task<string> GetUsernameAsync(int userID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GruppFem.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GruppFem.ServiceReference1.IService1>, GruppFem.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GruppFem.ServiceReference1.UserInfo[] GetUserInfo() {
            return base.Channel.GetUserInfo();
        }
        
        public System.Threading.Tasks.Task<GruppFem.ServiceReference1.UserInfo[]> GetUserInfoAsync() {
            return base.Channel.GetUserInfoAsync();
        }
        
        public GruppFem.ServiceReference1.EstablishmentInfo[] GetEstablishmentInfo(System.Nullable<int> userID) {
            return base.Channel.GetEstablishmentInfo(userID);
        }
        
        public System.Threading.Tasks.Task<GruppFem.ServiceReference1.EstablishmentInfo[]> GetEstablishmentInfoAsync(System.Nullable<int> userID) {
            return base.Channel.GetEstablishmentInfoAsync(userID);
        }
        
        public void DeleteUser(int userID) {
            base.Channel.DeleteUser(userID);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int userID) {
            return base.Channel.DeleteUserAsync(userID);
        }
        
        public void CreateUser(string username, string password, string firstname, string lastname, string email) {
            base.Channel.CreateUser(username, password, firstname, lastname, email);
        }
        
        public System.Threading.Tasks.Task CreateUserAsync(string username, string password, string firstname, string lastname, string email) {
            return base.Channel.CreateUserAsync(username, password, firstname, lastname, email);
        }
        
        public void UpdateUser(int userID, string username, string password, string firstname, string lastname, string email) {
            base.Channel.UpdateUser(userID, username, password, firstname, lastname, email);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(int userID, string username, string password, string firstname, string lastname, string email) {
            return base.Channel.UpdateUserAsync(userID, username, password, firstname, lastname, email);
        }
        
        public void UpdateEstablishment(int establishmentID, int rating, int userID) {
            base.Channel.UpdateEstablishment(establishmentID, rating, userID);
        }
        
        public System.Threading.Tasks.Task UpdateEstablishmentAsync(int establishmentID, int rating, int userID) {
            return base.Channel.UpdateEstablishmentAsync(establishmentID, rating, userID);
        }
        
        public bool LoginUser(string username, string password) {
            return base.Channel.LoginUser(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginUserAsync(string username, string password) {
            return base.Channel.LoginUserAsync(username, password);
        }
        
        public int GetUserID(string username, string password) {
            return base.Channel.GetUserID(username, password);
        }
        
        public System.Threading.Tasks.Task<int> GetUserIDAsync(string username, string password) {
            return base.Channel.GetUserIDAsync(username, password);
        }
        
        public GruppFem.ServiceReference1.EstablishmentInfo[] GetEstablishments() {
            return base.Channel.GetEstablishments();
        }
        
        public System.Threading.Tasks.Task<GruppFem.ServiceReference1.EstablishmentInfo[]> GetEstablishmentsAsync() {
            return base.Channel.GetEstablishmentsAsync();
        }
        
        public string GetUsername(int userID) {
            return base.Channel.GetUsername(userID);
        }
        
        public System.Threading.Tasks.Task<string> GetUsernameAsync(int userID) {
            return base.Channel.GetUsernameAsync(userID);
        }
    }
}

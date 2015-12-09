﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreWinform.GroupService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Group", Namespace="http://schemas.datacontract.org/2004/07/BookstoreService.EF")]
    [System.SerializableAttribute()]
    public partial class Group : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModifiedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModifiedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RolesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
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
        public System.Nullable<System.DateTime> CreatedAt {
            get {
                return this.CreatedAtField;
            }
            set {
                if ((this.CreatedAtField.Equals(value) != true)) {
                    this.CreatedAtField = value;
                    this.RaisePropertyChanged("CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreatedBy {
            get {
                return this.CreatedByField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatedByField, value) != true)) {
                    this.CreatedByField = value;
                    this.RaisePropertyChanged("CreatedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifiedAt {
            get {
                return this.ModifiedAtField;
            }
            set {
                if ((this.ModifiedAtField.Equals(value) != true)) {
                    this.ModifiedAtField = value;
                    this.RaisePropertyChanged("ModifiedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModifiedBy {
            get {
                return this.ModifiedByField;
            }
            set {
                if ((object.ReferenceEquals(this.ModifiedByField, value) != true)) {
                    this.ModifiedByField = value;
                    this.RaisePropertyChanged("ModifiedBy");
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
        public string Roles {
            get {
                return this.RolesField;
            }
            set {
                if ((object.ReferenceEquals(this.RolesField, value) != true)) {
                    this.RolesField = value;
                    this.RaisePropertyChanged("Roles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GroupService.IGroup")]
    public interface IGroup {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/findAll", ReplyAction="http://tempuri.org/IModelOf_Group/findAllResponse")]
        BookStoreWinform.GroupService.Group[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/findAll", ReplyAction="http://tempuri.org/IModelOf_Group/findAllResponse")]
        System.Threading.Tasks.Task<BookStoreWinform.GroupService.Group[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/findById", ReplyAction="http://tempuri.org/IModelOf_Group/findByIdResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookStoreWinform.GroupService.Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookStoreWinform.GroupService.Group))]
        BookStoreWinform.GroupService.Group findById(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/findById", ReplyAction="http://tempuri.org/IModelOf_Group/findByIdResponse")]
        System.Threading.Tasks.Task<BookStoreWinform.GroupService.Group> findByIdAsync(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/insert", ReplyAction="http://tempuri.org/IModelOf_Group/insertResponse")]
        long insert(BookStoreWinform.GroupService.Group entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/insert", ReplyAction="http://tempuri.org/IModelOf_Group/insertResponse")]
        System.Threading.Tasks.Task<long> insertAsync(BookStoreWinform.GroupService.Group entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/update", ReplyAction="http://tempuri.org/IModelOf_Group/updateResponse")]
        bool update(BookStoreWinform.GroupService.Group entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/update", ReplyAction="http://tempuri.org/IModelOf_Group/updateResponse")]
        System.Threading.Tasks.Task<bool> updateAsync(BookStoreWinform.GroupService.Group entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/delete", ReplyAction="http://tempuri.org/IModelOf_Group/deleteResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookStoreWinform.GroupService.Group[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BookStoreWinform.GroupService.Group))]
        bool delete(object id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Group/delete", ReplyAction="http://tempuri.org/IModelOf_Group/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(object id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGroupChannel : BookStoreWinform.GroupService.IGroup, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupClient : System.ServiceModel.ClientBase<BookStoreWinform.GroupService.IGroup>, BookStoreWinform.GroupService.IGroup {
        
        public GroupClient() {
        }
        
        public GroupClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookStoreWinform.GroupService.Group[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<BookStoreWinform.GroupService.Group[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public BookStoreWinform.GroupService.Group findById(object id) {
            return base.Channel.findById(id);
        }
        
        public System.Threading.Tasks.Task<BookStoreWinform.GroupService.Group> findByIdAsync(object id) {
            return base.Channel.findByIdAsync(id);
        }
        
        public long insert(BookStoreWinform.GroupService.Group entity) {
            return base.Channel.insert(entity);
        }
        
        public System.Threading.Tasks.Task<long> insertAsync(BookStoreWinform.GroupService.Group entity) {
            return base.Channel.insertAsync(entity);
        }
        
        public bool update(BookStoreWinform.GroupService.Group entity) {
            return base.Channel.update(entity);
        }
        
        public System.Threading.Tasks.Task<bool> updateAsync(BookStoreWinform.GroupService.Group entity) {
            return base.Channel.updateAsync(entity);
        }
        
        public bool delete(object id) {
            return base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(object id) {
            return base.Channel.deleteAsync(id);
        }
    }
}

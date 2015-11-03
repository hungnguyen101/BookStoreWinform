﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreWinform.CategoryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/BookStoreService.EF")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
        private System.Nullable<int> ParentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public System.Nullable<int> ParentID {
            get {
                return this.ParentIDField;
            }
            set {
                if ((this.ParentIDField.Equals(value) != true)) {
                    this.ParentIDField = value;
                    this.RaisePropertyChanged("ParentID");
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryService.ICategory")]
    public interface ICategory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/findAll", ReplyAction="http://tempuri.org/IModelOf_Category/findAllResponse")]
        BookStoreWinform.CategoryService.Category[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/findAll", ReplyAction="http://tempuri.org/IModelOf_Category/findAllResponse")]
        System.Threading.Tasks.Task<BookStoreWinform.CategoryService.Category[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/findById", ReplyAction="http://tempuri.org/IModelOf_Category/findByIdResponse")]
        BookStoreWinform.CategoryService.Category findById(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/findById", ReplyAction="http://tempuri.org/IModelOf_Category/findByIdResponse")]
        System.Threading.Tasks.Task<BookStoreWinform.CategoryService.Category> findByIdAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/insert", ReplyAction="http://tempuri.org/IModelOf_Category/insertResponse")]
        long insert(BookStoreWinform.CategoryService.Category entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/insert", ReplyAction="http://tempuri.org/IModelOf_Category/insertResponse")]
        System.Threading.Tasks.Task<long> insertAsync(BookStoreWinform.CategoryService.Category entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/update", ReplyAction="http://tempuri.org/IModelOf_Category/updateResponse")]
        bool update(BookStoreWinform.CategoryService.Category entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/update", ReplyAction="http://tempuri.org/IModelOf_Category/updateResponse")]
        System.Threading.Tasks.Task<bool> updateAsync(BookStoreWinform.CategoryService.Category entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/delete", ReplyAction="http://tempuri.org/IModelOf_Category/deleteResponse")]
        bool delete(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModelOf_Category/delete", ReplyAction="http://tempuri.org/IModelOf_Category/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryChannel : BookStoreWinform.CategoryService.ICategory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryClient : System.ServiceModel.ClientBase<BookStoreWinform.CategoryService.ICategory>, BookStoreWinform.CategoryService.ICategory {
        
        public CategoryClient() {
        }
        
        public CategoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BookStoreWinform.CategoryService.Category[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<BookStoreWinform.CategoryService.Category[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public BookStoreWinform.CategoryService.Category findById(long id) {
            return base.Channel.findById(id);
        }
        
        public System.Threading.Tasks.Task<BookStoreWinform.CategoryService.Category> findByIdAsync(long id) {
            return base.Channel.findByIdAsync(id);
        }
        
        public long insert(BookStoreWinform.CategoryService.Category entity) {
            return base.Channel.insert(entity);
        }
        
        public System.Threading.Tasks.Task<long> insertAsync(BookStoreWinform.CategoryService.Category entity) {
            return base.Channel.insertAsync(entity);
        }
        
        public bool update(BookStoreWinform.CategoryService.Category entity) {
            return base.Channel.update(entity);
        }
        
        public System.Threading.Tasks.Task<bool> updateAsync(BookStoreWinform.CategoryService.Category entity) {
            return base.Channel.updateAsync(entity);
        }
        
        public bool delete(long id) {
            return base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(long id) {
            return base.Channel.deleteAsync(id);
        }
    }
}

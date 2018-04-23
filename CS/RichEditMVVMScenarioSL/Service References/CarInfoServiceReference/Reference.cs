﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace RichEditMVVMScenarioSL.CarInfoServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarInfo", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class CarInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string DescriptionField;
        
        private string NameField;
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarInfoServiceReference.ICarInfoService")]
    public interface ICarInfoService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICarInfoService/LoadCarInfo", ReplyAction="http://tempuri.org/ICarInfoService/LoadCarInfoResponse")]
        System.IAsyncResult BeginLoadCarInfo(System.AsyncCallback callback, object asyncState);
        
        RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo EndLoadCarInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICarInfoService/SaveCarInfo", ReplyAction="http://tempuri.org/ICarInfoService/SaveCarInfoResponse")]
        System.IAsyncResult BeginSaveCarInfo(RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo carInfo, System.AsyncCallback callback, object asyncState);
        
        void EndSaveCarInfo(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarInfoServiceChannel : RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoadCarInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public LoadCarInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarInfoServiceClient : System.ServiceModel.ClientBase<RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService>, RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService {
        
        private BeginOperationDelegate onBeginLoadCarInfoDelegate;
        
        private EndOperationDelegate onEndLoadCarInfoDelegate;
        
        private System.Threading.SendOrPostCallback onLoadCarInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginSaveCarInfoDelegate;
        
        private EndOperationDelegate onEndSaveCarInfoDelegate;
        
        private System.Threading.SendOrPostCallback onSaveCarInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public CarInfoServiceClient() {
        }
        
        public CarInfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarInfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarInfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<LoadCarInfoCompletedEventArgs> LoadCarInfoCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SaveCarInfoCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService.BeginLoadCarInfo(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLoadCarInfo(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService.EndLoadCarInfo(System.IAsyncResult result) {
            return base.Channel.EndLoadCarInfo(result);
        }
        
        private System.IAsyncResult OnBeginLoadCarInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService)(this)).BeginLoadCarInfo(callback, asyncState);
        }
        
        private object[] OnEndLoadCarInfo(System.IAsyncResult result) {
            RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo retVal = ((RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService)(this)).EndLoadCarInfo(result);
            return new object[] {
                    retVal};
        }
        
        private void OnLoadCarInfoCompleted(object state) {
            if ((this.LoadCarInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.LoadCarInfoCompleted(this, new LoadCarInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void LoadCarInfoAsync() {
            this.LoadCarInfoAsync(null);
        }
        
        public void LoadCarInfoAsync(object userState) {
            if ((this.onBeginLoadCarInfoDelegate == null)) {
                this.onBeginLoadCarInfoDelegate = new BeginOperationDelegate(this.OnBeginLoadCarInfo);
            }
            if ((this.onEndLoadCarInfoDelegate == null)) {
                this.onEndLoadCarInfoDelegate = new EndOperationDelegate(this.OnEndLoadCarInfo);
            }
            if ((this.onLoadCarInfoCompletedDelegate == null)) {
                this.onLoadCarInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLoadCarInfoCompleted);
            }
            base.InvokeAsync(this.onBeginLoadCarInfoDelegate, null, this.onEndLoadCarInfoDelegate, this.onLoadCarInfoCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService.BeginSaveCarInfo(RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo carInfo, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSaveCarInfo(carInfo, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService.EndSaveCarInfo(System.IAsyncResult result) {
            base.Channel.EndSaveCarInfo(result);
        }
        
        private System.IAsyncResult OnBeginSaveCarInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo carInfo = ((RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo)(inValues[0]));
            return ((RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService)(this)).BeginSaveCarInfo(carInfo, callback, asyncState);
        }
        
        private object[] OnEndSaveCarInfo(System.IAsyncResult result) {
            ((RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService)(this)).EndSaveCarInfo(result);
            return null;
        }
        
        private void OnSaveCarInfoCompleted(object state) {
            if ((this.SaveCarInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SaveCarInfoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SaveCarInfoAsync(RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo carInfo) {
            this.SaveCarInfoAsync(carInfo, null);
        }
        
        public void SaveCarInfoAsync(RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo carInfo, object userState) {
            if ((this.onBeginSaveCarInfoDelegate == null)) {
                this.onBeginSaveCarInfoDelegate = new BeginOperationDelegate(this.OnBeginSaveCarInfo);
            }
            if ((this.onEndSaveCarInfoDelegate == null)) {
                this.onEndSaveCarInfoDelegate = new EndOperationDelegate(this.OnEndSaveCarInfo);
            }
            if ((this.onSaveCarInfoCompletedDelegate == null)) {
                this.onSaveCarInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSaveCarInfoCompleted);
            }
            base.InvokeAsync(this.onBeginSaveCarInfoDelegate, new object[] {
                        carInfo}, this.onEndSaveCarInfoDelegate, this.onSaveCarInfoCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService CreateChannel() {
            return new CarInfoServiceClientChannel(this);
        }
        
        private class CarInfoServiceClientChannel : ChannelBase<RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService>, RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService {
            
            public CarInfoServiceClientChannel(System.ServiceModel.ClientBase<RichEditMVVMScenarioSL.CarInfoServiceReference.ICarInfoService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginLoadCarInfo(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("LoadCarInfo", _args, callback, asyncState);
                return _result;
            }
            
            public RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo EndLoadCarInfo(System.IAsyncResult result) {
                object[] _args = new object[0];
                RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo _result = ((RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo)(base.EndInvoke("LoadCarInfo", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginSaveCarInfo(RichEditMVVMScenarioSL.CarInfoServiceReference.CarInfo carInfo, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = carInfo;
                System.IAsyncResult _result = base.BeginInvoke("SaveCarInfo", _args, callback, asyncState);
                return _result;
            }
            
            public void EndSaveCarInfo(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("SaveCarInfo", _args, result);
            }
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEST_WS_COMMAND.NS_WS_LOCAL {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="C_BOIS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class C_BOIS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idBoisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrigineField;
        
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
        public int idBois {
            get {
                return this.idBoisField;
            }
            set {
                if ((this.idBoisField.Equals(value) != true)) {
                    this.idBoisField = value;
                    this.RaisePropertyChanged("idBois");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Origine {
            get {
                return this.OrigineField;
            }
            set {
                if ((object.ReferenceEquals(this.OrigineField, value) != true)) {
                    this.OrigineField = value;
                    this.RaisePropertyChanged("Origine");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NS_WS_LOCAL.WS_GUITARESoap")]
    public interface WS_GUITARESoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément GetDateResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDate", ReplyAction="*")]
        TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponse GetDate(TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDate", ReplyAction="*")]
        System.Threading.Tasks.Task<TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponse> GetDateAsync(TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément Donne_Liste_BoisResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Donne_Liste_Bois", ReplyAction="*")]
        TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponse Donne_Liste_Bois(TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Donne_Liste_Bois", ReplyAction="*")]
        System.Threading.Tasks.Task<TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponse> Donne_Liste_BoisAsync(TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDate", Namespace="http://tempuri.org/", Order=0)]
        public TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequestBody Body;
        
        public GetDateRequest() {
        }
        
        public GetDateRequest(TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetDateRequestBody {
        
        public GetDateRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateResponse", Namespace="http://tempuri.org/", Order=0)]
        public TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponseBody Body;
        
        public GetDateResponse() {
        }
        
        public GetDateResponse(TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetDateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetDateResult;
        
        public GetDateResponseBody() {
        }
        
        public GetDateResponseBody(string GetDateResult) {
            this.GetDateResult = GetDateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Donne_Liste_BoisRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Donne_Liste_Bois", Namespace="http://tempuri.org/", Order=0)]
        public TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequestBody Body;
        
        public Donne_Liste_BoisRequest() {
        }
        
        public Donne_Liste_BoisRequest(TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class Donne_Liste_BoisRequestBody {
        
        public Donne_Liste_BoisRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Donne_Liste_BoisResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Donne_Liste_BoisResponse", Namespace="http://tempuri.org/", Order=0)]
        public TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponseBody Body;
        
        public Donne_Liste_BoisResponse() {
        }
        
        public Donne_Liste_BoisResponse(TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Donne_Liste_BoisResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TEST_WS_COMMAND.NS_WS_LOCAL.C_BOIS[] Donne_Liste_BoisResult;
        
        public Donne_Liste_BoisResponseBody() {
        }
        
        public Donne_Liste_BoisResponseBody(TEST_WS_COMMAND.NS_WS_LOCAL.C_BOIS[] Donne_Liste_BoisResult) {
            this.Donne_Liste_BoisResult = Donne_Liste_BoisResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_GUITARESoapChannel : TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_GUITARESoapClient : System.ServiceModel.ClientBase<TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap>, TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap {
        
        public WS_GUITARESoapClient() {
        }
        
        public WS_GUITARESoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_GUITARESoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_GUITARESoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_GUITARESoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponse TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap.GetDate(TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest request) {
            return base.Channel.GetDate(request);
        }
        
        public string GetDate() {
            TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest inValue = new TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest();
            inValue.Body = new TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequestBody();
            TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponse retVal = ((TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap)(this)).GetDate(inValue);
            return retVal.Body.GetDateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponse> TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap.GetDateAsync(TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest request) {
            return base.Channel.GetDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<TEST_WS_COMMAND.NS_WS_LOCAL.GetDateResponse> GetDateAsync() {
            TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest inValue = new TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequest();
            inValue.Body = new TEST_WS_COMMAND.NS_WS_LOCAL.GetDateRequestBody();
            return ((TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap)(this)).GetDateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponse TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap.Donne_Liste_Bois(TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest request) {
            return base.Channel.Donne_Liste_Bois(request);
        }
        
        public TEST_WS_COMMAND.NS_WS_LOCAL.C_BOIS[] Donne_Liste_Bois() {
            TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest inValue = new TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest();
            inValue.Body = new TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequestBody();
            TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponse retVal = ((TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap)(this)).Donne_Liste_Bois(inValue);
            return retVal.Body.Donne_Liste_BoisResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponse> TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap.Donne_Liste_BoisAsync(TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest request) {
            return base.Channel.Donne_Liste_BoisAsync(request);
        }
        
        public System.Threading.Tasks.Task<TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisResponse> Donne_Liste_BoisAsync() {
            TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest inValue = new TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequest();
            inValue.Body = new TEST_WS_COMMAND.NS_WS_LOCAL.Donne_Liste_BoisRequestBody();
            return ((TEST_WS_COMMAND.NS_WS_LOCAL.WS_GUITARESoap)(this)).Donne_Liste_BoisAsync(inValue);
        }
    }
}

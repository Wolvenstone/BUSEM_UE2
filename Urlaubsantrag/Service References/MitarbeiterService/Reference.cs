﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Urlaubsantrag.MitarbeiterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MitarbeiterService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/StartUrlaubsantrag", ReplyAction="http://tempuri.org/IService/StartUrlaubsantragResponse")]
        Urlaubsantrag.MitarbeiterService.StartUrlaubsantragResponse StartUrlaubsantrag(Urlaubsantrag.MitarbeiterService.StartUrlaubsantragRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/StartUrlaubsantrag", ReplyAction="http://tempuri.org/IService/StartUrlaubsantragResponse")]
        System.Threading.Tasks.Task<Urlaubsantrag.MitarbeiterService.StartUrlaubsantragResponse> StartUrlaubsantragAsync(Urlaubsantrag.MitarbeiterService.StartUrlaubsantragRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAnswer", ReplyAction="http://tempuri.org/IService/GetAnswerResponse")]
        Urlaubsantrag.MitarbeiterService.GetAnswerResponse GetAnswer(Urlaubsantrag.MitarbeiterService.GetAnswerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAnswer", ReplyAction="http://tempuri.org/IService/GetAnswerResponse")]
        System.Threading.Tasks.Task<Urlaubsantrag.MitarbeiterService.GetAnswerResponse> GetAnswerAsync(Urlaubsantrag.MitarbeiterService.GetAnswerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAntwort", ReplyAction="http://tempuri.org/IService/GetAntwortResponse")]
        Urlaubsantrag.MitarbeiterService.GetAntwortResponse GetAntwort(Urlaubsantrag.MitarbeiterService.GetAntwortRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAntwort", ReplyAction="http://tempuri.org/IService/GetAntwortResponse")]
        System.Threading.Tasks.Task<Urlaubsantrag.MitarbeiterService.GetAntwortResponse> GetAntwortAsync(Urlaubsantrag.MitarbeiterService.GetAntwortRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartUrlaubsantrag", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class StartUrlaubsantragRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UrlaubsantragService.Contract.Urlaubsantrag antrag;
        
        public StartUrlaubsantragRequest() {
        }
        
        public StartUrlaubsantragRequest(UrlaubsantragService.Contract.Urlaubsantrag antrag) {
            this.antrag = antrag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="StartUrlaubsantragResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class StartUrlaubsantragResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string serviceCorrelationid;
        
        public StartUrlaubsantragResponse() {
        }
        
        public StartUrlaubsantragResponse(string serviceCorrelationid) {
            this.serviceCorrelationid = serviceCorrelationid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAnswer", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAnswerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public UrlaubsantragService.Contract.Genehmigung genehmigung;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public UrlaubsantragService.Contract.Ablehnung ablehnung;
        
        public GetAnswerRequest() {
        }
        
        public GetAnswerRequest(string id, UrlaubsantragService.Contract.Genehmigung genehmigung, UrlaubsantragService.Contract.Ablehnung ablehnung) {
            this.id = id;
            this.genehmigung = genehmigung;
            this.ablehnung = ablehnung;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAnswerResponse {
        
        public GetAnswerResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAntwort", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAntwortRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string correlationId;
        
        public GetAntwortRequest() {
        }
        
        public GetAntwortRequest(string correlationId) {
            this.correlationId = correlationId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAntwortResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAntwortResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string answer;
        
        public GetAntwortResponse() {
        }
        
        public GetAntwortResponse(string answer) {
            this.answer = answer;
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Urlaubsantrag.VorgesetzterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VorgesetzterService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AntragEmpfangen", ReplyAction="http://tempuri.org/IService/AntragEmpfangenResponse")]
        Urlaubsantrag.VorgesetzterService.AntragEmpfangenResponse AntragEmpfangen(Urlaubsantrag.VorgesetzterService.AntragEmpfangenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AntragEmpfangen", ReplyAction="http://tempuri.org/IService/AntragEmpfangenResponse")]
        System.Threading.Tasks.Task<Urlaubsantrag.VorgesetzterService.AntragEmpfangenResponse> AntragEmpfangenAsync(Urlaubsantrag.VorgesetzterService.AntragEmpfangenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AntragBewerten", ReplyAction="http://tempuri.org/IService/AntragBewertenResponse")]
        Urlaubsantrag.VorgesetzterService.AntragBewertenResponse AntragBewerten(Urlaubsantrag.VorgesetzterService.AntragBewertenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AntragBewerten", ReplyAction="http://tempuri.org/IService/AntragBewertenResponse")]
        System.Threading.Tasks.Task<Urlaubsantrag.VorgesetzterService.AntragBewertenResponse> AntragBewertenAsync(Urlaubsantrag.VorgesetzterService.AntragBewertenRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AntragEmpfangen", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AntragEmpfangenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UrlaubsantragService.Contract.Urlaubsantrag antrag;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string correlationId;
        
        public AntragEmpfangenRequest() {
        }
        
        public AntragEmpfangenRequest(UrlaubsantragService.Contract.Urlaubsantrag antrag, string correlationId) {
            this.antrag = antrag;
            this.correlationId = correlationId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AntragEmpfangenResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AntragEmpfangenResponse {
        
        public AntragEmpfangenResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AntragBewerten", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AntragBewertenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string correlationid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public bool genehmigt;
        
        public AntragBewertenRequest() {
        }
        
        public AntragBewertenRequest(string correlationid, bool genehmigt) {
            this.correlationid = correlationid;
            this.genehmigt = genehmigt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AntragBewertenResponse {
        
        public AntragBewertenResponse() {
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicacion_Windows_form.ServiceReference2 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Persona", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Persona();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Persona", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> PersonaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet insertar(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insertar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> insertarAsync(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet eliminar(int ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> eliminarAsync(int ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet actualizar(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> actualizarAsync(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Aplicacion_Windows_form.ServiceReference2.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Aplicacion_Windows_form.ServiceReference2.WebService1Soap>, Aplicacion_Windows_form.ServiceReference2.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet Persona() {
            return base.Channel.Persona();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> PersonaAsync() {
            return base.Channel.PersonaAsync();
        }
        
        public System.Data.DataSet insertar(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto) {
            return base.Channel.insertar(ci, nombre, fecha_nac, telefono, depto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> insertarAsync(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto) {
            return base.Channel.insertarAsync(ci, nombre, fecha_nac, telefono, depto);
        }
        
        public System.Data.DataSet eliminar(int ci) {
            return base.Channel.eliminar(ci);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> eliminarAsync(int ci) {
            return base.Channel.eliminarAsync(ci);
        }
        
        public System.Data.DataSet actualizar(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto) {
            return base.Channel.actualizar(ci, nombre, fecha_nac, telefono, depto);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> actualizarAsync(int ci, string nombre, System.DateTime fecha_nac, string telefono, string depto) {
            return base.Channel.actualizarAsync(ci, nombre, fecha_nac, telefono, depto);
        }
    }
}

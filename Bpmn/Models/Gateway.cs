/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(InclusiveGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ExclusiveGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EventBasedGateway))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ComplexGateway))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
public partial class Gateway : FlowNode {
    
    private GatewayDirection gatewayDirectionField;
    
    public Gateway() {
        this.gatewayDirectionField = GatewayDirection.Unspecified;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(GatewayDirection.Unspecified)]
    public GatewayDirection gatewayDirection {
        get {
            return this.gatewayDirectionField;
        }
        set {
            this.gatewayDirectionField = value;
        }
    }
}
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("eventBasedGateway", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class EventBasedGateway : Gateway {
    
    private bool instantiateField;
    
    private EventBasedGatewayType eventGatewayTypeField;
    
    public EventBasedGateway() {
        this.instantiateField = false;
        this.eventGatewayTypeField = EventBasedGatewayType.Exclusive;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool instantiate {
        get {
            return this.instantiateField;
        }
        set {
            this.instantiateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(EventBasedGatewayType.Exclusive)]
    public EventBasedGatewayType eventGatewayType {
        get {
            return this.eventGatewayTypeField;
        }
        set {
            this.eventGatewayTypeField = value;
        }
    }
}
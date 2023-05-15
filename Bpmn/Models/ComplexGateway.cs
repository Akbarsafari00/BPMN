/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("complexGateway", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ComplexGateway : Gateway {
    
    private Expression activationConditionField;
    
    private string defaultField;
    
    /// <remarks/>
    public Expression activationCondition {
        get {
            return this.activationConditionField;
        }
        set {
            this.activationConditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string @default {
        get {
            return this.defaultField;
        }
        set {
            this.defaultField = value;
        }
    }
}
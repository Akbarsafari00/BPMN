/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("standardLoopCharacteristics", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class StandardLoopCharacteristics : LoopCharacteristics {
    
    private Expression loopConditionField;
    
    private bool testBeforeField;
    
    private string loopMaximumField;
    
    public StandardLoopCharacteristics() {
        this.testBeforeField = false;
    }
    
    /// <remarks/>
    public Expression loopCondition {
        get {
            return this.loopConditionField;
        }
        set {
            this.loopConditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool testBefore {
        get {
            return this.testBeforeField;
        }
        set {
            this.testBeforeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string loopMaximum {
        get {
            return this.loopMaximumField;
        }
        set {
            this.loopMaximumField = value;
        }
    }
}
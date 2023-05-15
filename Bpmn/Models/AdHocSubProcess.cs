/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("adHocSubProcess", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class AdHocSubProcess : SubProcess {
    
    private Expression completionConditionField;
    
    private bool cancelRemainingInstancesField;
    
    private AdHocOrdering orderingField;
    
    private bool orderingFieldSpecified;
    
    public AdHocSubProcess() {
        this.cancelRemainingInstancesField = true;
    }
    
    /// <remarks/>
    public Expression completionCondition {
        get {
            return this.completionConditionField;
        }
        set {
            this.completionConditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool cancelRemainingInstances {
        get {
            return this.cancelRemainingInstancesField;
        }
        set {
            this.cancelRemainingInstancesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AdHocOrdering ordering {
        get {
            return this.orderingField;
        }
        set {
            this.orderingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool orderingSpecified {
        get {
            return this.orderingFieldSpecified;
        }
        set {
            this.orderingFieldSpecified = value;
        }
    }
}
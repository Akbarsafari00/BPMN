/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(IntermediateThrowEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplicitThrowEvent))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EndEvent))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("throwEvent", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class ThrowEvent : Event {
    
    private DataInput[] dataInputField;
    
    private DataInputAssociation[] dataInputAssociationField;
    
    private InputSet inputSetField;
    
    private EventDefinition[] itemsField;
    
    private System.Xml.XmlQualifiedName[] eventDefinitionRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataInput")]
    public DataInput[] dataInput {
        get {
            return this.dataInputField;
        }
        set {
            this.dataInputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dataInputAssociation")]
    public DataInputAssociation[] dataInputAssociation {
        get {
            return this.dataInputAssociationField;
        }
        set {
            this.dataInputAssociationField = value;
        }
    }
    
    /// <remarks/>
    public InputSet inputSet {
        get {
            return this.inputSetField;
        }
        set {
            this.inputSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cancelEventDefinition", typeof(CancelEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("compensateEventDefinition", typeof(CompensateEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("conditionalEventDefinition", typeof(ConditionalEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("errorEventDefinition", typeof(ErrorEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("escalationEventDefinition", typeof(EscalationEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("eventDefinition", typeof(EventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("linkEventDefinition", typeof(LinkEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("messageEventDefinition", typeof(MessageEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("signalEventDefinition", typeof(SignalEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("terminateEventDefinition", typeof(TerminateEventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("timerEventDefinition", typeof(TimerEventDefinition))]
    public EventDefinition[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("eventDefinitionRef")]
    public System.Xml.XmlQualifiedName[] eventDefinitionRef {
        get {
            return this.eventDefinitionRefField;
        }
        set {
            this.eventDefinitionRefField = value;
        }
    }
}
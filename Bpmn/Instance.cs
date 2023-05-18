using Bpmn.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bpmn
{
    public class Instance
    {
        private readonly Definitions _definitions;

        public Instance(string diagram)
        {
            var inputString = File.ReadAllText("C:\\Users\\isar\\source\\repos\\BPMN\\Bpmn.Console\\" + diagram);
            var serializer = new XmlSerializer(typeof(Definitions));
            var memStream = new MemoryStream(Encoding.UTF8.GetBytes(inputString));

            _definitions = (Definitions)serializer.Deserialize(memStream)!;
            CurrentFlowElement = _definitions.FirstProcess().Items.FirstStartEvent();
            Status = "Pending";
            Step = CurrentFlowElement.id;

        }

        public string Status { get; set; }
        public string Step { get; set; }
        public FlowElement CurrentFlowElement { get; set; }
        public IEnumerable<Process> AllProcess()
        {
            return _definitions.Items.FindElementsByType<Process>();
        }


        public async System.Threading.Tasks.Task StartAsync()
        {
            foreach (var process in AllProcess())
            {
                while (Status != "Done" && Status != "Cancelled")
                {
                    await DoProcessAsync(process);
                }
            }
        }

        private async System.Threading.Tasks.Task DoProcessAsync(Process process)
        {

            switch (CurrentFlowElement)
            {
                case StartEvent:
                    await DoStartEventProcess((StartEvent) CurrentFlowElement);
                    break;
                case ServiceTask:
                    await DoServiceTaskProcess((ServiceTask) CurrentFlowElement);
                    break;
                case UserTask:
                    await DoUserTaskProcess((UserTask)CurrentFlowElement);
                    break;
                case Gateway:
                    await DoGatewayProcess((Gateway)CurrentFlowElement);
                    break;
                case EndEvent:
                    await DoEndEventProcess((EndEvent)CurrentFlowElement);
                    break;
            }

            await FindNextStep(process);

        }

        private async System.Threading.Tasks.Task DoStartEventProcess(StartEvent startEvent)
        {
            Status = "Executing";
        }

        private async System.Threading.Tasks.Task DoServiceTaskProcess(ServiceTask serviceTask)
        {
            Status = "Executing";
            Console.WriteLine(serviceTask.id);
        }
        private async System.Threading.Tasks.Task DoUserTaskProcess(UserTask userTask)
        {
            Status = "Waiting";
            Console.WriteLine(userTask.id);
        }
        private async System.Threading.Tasks.Task DoGatewayProcess(Gateway gateway)
        {
            Status = "Dessiccion";
            Console.WriteLine(gateway.id);
        }

        private async System.Threading.Tasks.Task DoEndEventProcess(EndEvent endEvent)
        {
            Status = "Done";
            Console.WriteLine(endEvent.id);
        }

        private async System.Threading.Tasks.Task FindNextStep(Process process)
        {
            var flow = process.FindSequenceFlowBySourceRef(CurrentFlowElement.id);
            if (flow != null)
            {
                CurrentFlowElement = process.FirstElementById(flow.targetRef);
                Step = CurrentFlowElement.id;
            }
           
        }

    }
}

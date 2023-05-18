using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bpmn.Contracts
{
    public interface IUserTaskHandler<TInput,TOutput> where TInput : IUserTask<TOutput>
    {
        Task<TOutput> HandleAsync(TInput input);
    }
}

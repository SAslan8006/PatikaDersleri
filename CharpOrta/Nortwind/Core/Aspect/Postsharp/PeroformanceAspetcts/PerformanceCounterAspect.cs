using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspect.Postsharp.PeroformanceAspects
{
    [Serializable]
    public class PerformanceCounterAspect:OnMethodBoundaryAspect
    {
        int _interval;
        [NonSerialized]
        Stopwatch _stopwatch;


        public PerformanceCounterAspect(int interval=5)
        {
            _interval = interval;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            _stopwatch = Activator.CreateInstance<Stopwatch>();

        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
            base.OnEntry(args);
        }
        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch?.Stop();
            if (_stopwatch.Elapsed.TotalSeconds>_interval)
            {
                Debug.WriteLine($"Performance: {args.Method.DeclaringType.FullName}.{args.Method.DeclaringType.Name}=> {_stopwatch.Elapsed.TotalSeconds} ");
            }
            _stopwatch.Reset();
            base.OnExit(args);
        }

    }
}

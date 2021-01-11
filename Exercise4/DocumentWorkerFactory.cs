using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    interface DocumentWorkerFactory
    {
        public static IDocumentWorker GetInstance(string key)
        {
            return (key) switch
            {
                "1" => new ProDocumentWorker(),
                "2" => new ExpertDocumentWorker(),
                "" => new DocumentWorker(),
                _ => null,
            };
        }
    }
}

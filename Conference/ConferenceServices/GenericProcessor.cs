using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceInterfaces;
using ConferenceRepos;

namespace ConferenceServices
{
    public class GenericProcessor : IGenericProcessor
    {
        List<IProcess> _listToProcess;
        GenericRepo _repository;

        public GenericProcessor(GenericRepo repository)
        {
            _repository = repository;
            _listToProcess = _repository.GetThingsToProcess();
        }

        public void OpenThings()
        {
            //foreach (IProcess item in _listToProcess)
            //{
            //    item.Connect();
            //}
        }

        public void PrintThings()
        {
            foreach (IProcess item in _listToProcess)
            {
                item.PrintTo();
            }
        }
    }
}

using services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace services.Controllers
{
    public class stagesController : ApiController
    {
        //get the list of all projects of user
        public IEnumerable<progresi_stages> getStages(string uid,string session)
        {
            return null;
        }
        //get specific instance of a stage
        public progresi_stages getStage(int sid,string uid,string session)
        {
         // TODO: Develop some code here
          return null;
        }

        public bool setStage(progresi_stages stage)
        {
            //TODO: develop some code to create new stage
            return true;
        }

        public bool updateStage(progresi_stages stage)
        {
            //TODO: develop some code to update an entry stage
            return true;
        }

        public bool deleteStage(int id)
        {
            //TODO: develop some code to delete entry stage
            return true;
        }

        public IEnumerable<progresi_tasks> getTasks(int pid)
        {
            //TODO: develop some code to get project tasks
            return null;
        }
    }
}
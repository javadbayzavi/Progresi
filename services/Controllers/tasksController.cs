using services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace services.Controllers
{
    public class tasksController : ApiController
    {
        //get the list of all projects of user
        public IEnumerable<progresi_tasks> getTasks(string uid,string session)
        {
            return null;
        }
        //get specific instance of a task
        public progresi_tasks getTask(int tid,string uid,string session)
        {
         // TODO: Develop some code here
          return null;
        }

        public bool setTask(progresi_tasks task)
        {
            //TODO: develop some code to create new task
            return true;
        }

        public bool updateTask(progresi_tasks task)
        {
            //TODO: develop some code to update an entry task
            return true;
        }

        public bool deleteTask(int id)
        {
            //TODO: develop some code to delete entry task
            return true;
        }

        public IEnumerable<progresi_task_categories> getCategories(int pid)
        {
            //TODO: develop some code to get project tasks
            return null;
        }

    }
}
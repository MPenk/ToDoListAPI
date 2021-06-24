using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {

        // POST <ToDoListController>/{id}
        [HttpPost("{id}")]
        public string PostShowById(int id)
        {
            try
            {
                return ToDoListItem.GetTask(id).TaskName;
            }
            catch (Exception)
            {

                return "BRAK";
            }
        }

        // POST <ToDoListController>/all
        [HttpPost("all")]
        public IEnumerable<ToDoListItem> PostShowAll()
        {
            return ToDoListItem.GetTasks();
        }

        // GET <ToDoListController>/all
        [HttpGet("all")]
        public IEnumerable<ToDoListItem> GetShowAll()
        {
            return ToDoListItem.GetTasks();
        }

        // POST <ToDoListController>/all?taskName={taskName}
        [HttpPost("add")]
        public int PostAddNew(string taskName)
        {
            try
            {
                ToDoListItem.AddTask(taskName);
            }
            catch (Exception)
            {
                return 0;
            }
            return 1;
        }

        // PUT <ToDoListController>/all?taskName={taskName}
        [HttpPut("add")]
        public int PUTAddNew(string taskName)
        {
            try
            {
                ToDoListItem.AddTask(taskName);
            }
            catch (Exception)
            {
                return 0;
            }
            return 1;
        }

        // POST <ToDoListController>/{id}/remove
        [HttpPost("{id}/remove")]
        public int PostRemoveById(int id)
        {
            try
            {
                ToDoListItem.RemoveTask(id);
            }
            catch (Exception)
            {
                return 0;
            }
            return 1;
        }

        // DELETE <ToDoListController>/{id}/remove
        [HttpDelete ("{id}/remove")]
        public int DeleteRemoveById(int id)
        {
            try
            {
                ToDoListItem.RemoveTask(id);
            }
            catch (Exception)
            {
                return 0;
            }
            return 1;
        }
    }
}

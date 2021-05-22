using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrustyKrabLog
{
    public class Information
    {
        private int id;
        private DateTime date;
        private string name;
        private string supervisor;
        private string notes;

        /// <summary>
        ///4-27-2021 Saung NEW 5L :  Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="supervisor"></param>
        /// <param name="notes"></param>
        public Information(int id, DateTime date, string name, string supervisor, string notes)
        {
            this.id = id;
            this.date = date;
            this.name = name;
            this.supervisor = supervisor;
            this.notes = notes;
        }
        //4-27-2021 Saung NEW 5L : get and set id
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        //4-27-2021 Saung NEW 5L :  get and set Date 
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        //4-27-2021 Saung NEW 5L :  get and set name
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        //4-27-2021 Saung NEW 5L :  get and set supervisor
        public string Supervisor
        {
            get
            {
                return supervisor;
            }

            set
            {
                supervisor = value;
            }
        }
        //4-27-2021 Saung NEW 5L :  get and set notes
        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
    }
}

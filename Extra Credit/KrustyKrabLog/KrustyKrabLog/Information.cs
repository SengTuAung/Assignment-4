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
        /// Constructor
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

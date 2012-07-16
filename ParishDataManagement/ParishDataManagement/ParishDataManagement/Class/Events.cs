using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParishDataManagement
{
    class Events
    {
        protected String strEventDate;
        protected String strEventPlace;
        protected String strAnnotation;

        public String EventDate
        {
            get { return this.strEventDate; }

            set { this.strEventDate = value; }
        }

        public String EventPlace
        {
            get { return this.strEventPlace; }

            set { this.strEventPlace = value; }
        }

        public String Annotation
        {
            get { return this.strAnnotation; }

            set { this.strAnnotation = value; }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
	    public int CourseId { get; set; }
	    public string Title { get; set; }
	    public int Credits { get; set; }

	    public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.DomainModels.Member
{
    public class Member : IMember<Member>
    {
        public Member()
        {
            Candidates = new HashSet<Member>();
            RegisterDate = DateTime.Now;
            LastModifyDate = DateTime.Now;
        }

        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string Address { get; set; }
        //public Sex? Sex { get; set; }
        public string IDCard { get; set; }
        //public string Phone { get; set; }

        public string TransactionPassword { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastModifyDate { get; set; }
        public Member RegisterBy { get; set; }

        public string ReferenceMemberID { get; set; }

        public virtual Member Reference { get; set; }
        public virtual ICollection<Member> Candidates { get; set; }
    }

    public interface IMember<T>
    {
        T Reference { get; set; }
        ICollection<T> Candidates { get; set; }
    }

    public enum Sex
    {
        Female,
        Male
    }

}

﻿namespace Task1.StorageSystem.Concrete.SearchCriteries.UserCriteries
{
    using System;
    using Entities;
    using Interfaces;

    [Serializable]
    public class CriterionMales : ICriteria<User>
    {
        public bool MeetCriteria(User user)
        {
            return user.Gender == Gender.Male;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface IRentalDao : IEntityRepository<Rental>
   {
       List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
   }
}

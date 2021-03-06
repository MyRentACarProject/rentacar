
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int rentalId);
        IResult DeliverCar(Rental rental);
        IResult IsCarCanBeRented(Rental rental);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetUndeliveredRentalDetails();
        IDataResult<List<RentalDetailDto>> GetDeliveredRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByRentalId(int rentalId);
    }
}

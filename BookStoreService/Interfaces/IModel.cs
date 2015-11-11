﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BookStoreService.Interfaces
{
    [ServiceContract]
    public interface IModel<T>
    {
        [OperationContract]
        List<T> findAll();

        [OperationContract]
        T findById(long id);

        [OperationContract]
        long insert(T entity);

        [OperationContract]
        bool update(T entity);

        [OperationContract]
        bool delete(long id);
    }
}

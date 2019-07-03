using System;
using System.Collections.Generic;
using System.Text;

namespace IU.Planning.ConApp
{
    /// <summary>
    /// Интерфейс сущности
    /// </summary>
    public interface IEntity
    {
        Guid Uid { get; set; }

    }
    /// <summary>
    /// Интерфейс хранилища
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStore<T> where T: class, IEntity
    {
        /// <summary>
        /// Список сущностей
        /// </summary>
        IEnumerable <T> Entities { get; }
        /// <summary>
        /// Добавить сущность
        /// </summary>
        /// <param name="entity">Сущность</param>
        void Add(T entity);

        /// <summary>
        /// Получить сущность
        /// </summary>
        /// <param name="uid">ID сущности</param>
        T Get(Guid uid);

        void Update(T entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="entity">сущность</param>
        void Delete(Guid uid);
       

    }
}


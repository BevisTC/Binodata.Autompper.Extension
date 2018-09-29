using System;
using AutoMapper;

namespace Binodata.Automapper.Extension
{
    public static class AutoMapperConverter
    {
        /// <summary>
        /// Convert to Model 
        /// </summary>
        /// <typeparam name="From"></typeparam>
        /// <typeparam name="To"></typeparam>
        /// <param name="config"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static To ConvertModel<From, To>(this MapperConfiguration config, From source, To destination)
        {
            IMapper mapper = config.CreateMapper();
            return mapper.Map<From, To>(source, destination);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="From"></typeparam>
        /// <typeparam name="To"></typeparam>
        /// <param name="config"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public static To ConvertModel<From, To>(this MapperConfiguration config, From source)
        {
            IMapper mapper = config.CreateMapper();
            return mapper.Map<From, To>(source);
        }
    }
}

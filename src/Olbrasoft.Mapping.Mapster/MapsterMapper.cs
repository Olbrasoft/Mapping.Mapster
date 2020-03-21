﻿namespace Olbrasoft.Mapping.Mapster
{
    public class MapsterMapper : IMapper
    {
        private readonly global::MapsterMapper.IMapper _mapper;

        public MapsterMapper(global::MapsterMapper.IMapper mapper) => _mapper = mapper;

        public TDestination MapTo<TDestination>(object source) => _mapper.Map<TDestination>(source);
    }
}
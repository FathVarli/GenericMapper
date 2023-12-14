using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace TestMapper.Mapper.AutoMapper;

public class AutoMapperAdapter : IMapperAdapter
{
    private readonly IMapper _mapper;

    public AutoMapperAdapter(IMapper mapper)
    {
        _mapper = mapper;
    }

    public TTarget Map<TTarget>(object itemToMapFrom) where TTarget : class
    {
        return _mapper.Map<TTarget>(itemToMapFrom);
    }

    public TTarget Map<TSource, TTarget>(TSource itemToMapFrom) where TSource : class where TTarget : class
    {
        return _mapper.Map<TSource, TTarget>(itemToMapFrom);
    }

    public TTarget Map<TSource, TTarget>(TSource itemToMapFrom, TTarget itemToMapTo)
        where TSource : class where TTarget : class
    {
        return _mapper.Map(itemToMapFrom, itemToMapTo);
    }

    public IQueryable<TTarget> ProjectTo<TSource, TTarget>(IQueryable<TSource> source)
    {
        return source.ProjectTo<TTarget>(_mapper.ConfigurationProvider);
    }
}
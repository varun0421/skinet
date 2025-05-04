using System;
using Core.Entities;

namespace Core.Specifications;

public class BranListSpecification : BaseSpecification<Product,string>
{
    public BranListSpecification()
    {
        AddSelect(x => x.Brand);
        ApplyDistinct();
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Interfaces;

public class InterfacesClass3
{
    private readonly List<string> _items = new();

    public string Name { get; } = "InterfacesClass3";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"InterfacesClass3: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Interfaces;

public class InterfacesClass4
{
    private readonly List<string> _items = new();

    public string Name { get; } = "InterfacesClass4";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"InterfacesClass4: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Interfaces;

public class InterfacesClass5
{
    private readonly List<string> _items = new();

    public string Name { get; } = "InterfacesClass5";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"InterfacesClass5: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Interfaces;

public class InterfacesClass1
{
    private readonly List<string> _items = new();

    public string Name { get; } = "InterfacesClass1";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"InterfacesClass1: {Count}";
    }
}

using System;
using System.Collections.Generic;

namespace ModManager.Mewgenics.Interfaces;

public class InterfacesClass2
{
    private readonly List<string> _items = new();

    public string Name { get; } = "InterfacesClass2";

    public int Count => _items.Count;

    public void Add(string value)
    {
        if (!string.IsNullOrWhiteSpace(value))
            _items.Add(value);
    }

    public bool Remove(string value)
    {
        return _items.Remove(value);
    }

    public IEnumerable<string> GetAll()
    {
        foreach (var item in _items)
            yield return item;
    }

    public override string ToString()
    {
        return $"InterfacesClass2: {Count}";
    }
}

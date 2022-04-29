public interface IRefCounter {
    // 引用计数
    int refCount {get;}

    // 增持
    void Retain();

    // 减持
    void Release();

    // 为零时的操作
    void OnRefZero();
}

public class RefCounter:IRefCounter
{
    public int refCount{get;privte  set  }
    
}

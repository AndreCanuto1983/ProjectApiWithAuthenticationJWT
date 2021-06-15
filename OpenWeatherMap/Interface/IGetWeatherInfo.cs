﻿namespace OpenWeatherMap.Interface
{
    public interface IGetWeatherInfo<T>
    {
        T GetWeatherInfo(string city, string appId = "27b5237d944993ebfe0a90cb000f38f1");
    }
}

﻿namespace CarWorld.Services.Home
{
    using CarWorld.ViewModels.HomePageViewModels;

    public interface ILatestCarsService
    {
        IndexViewModel CollectData();
    }
}

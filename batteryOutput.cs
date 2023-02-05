public Program()
{
   Runtime.UpdateFrequency = UpdateFrequency.Update10;
}

public void Save()
{
    
}

public void Main(string argument, UpdateType updateSource)
{
    //Declare blocks.
    IMyBatteryBlock PowerStorage1;
    IMyBatteryBlock PowerStorage2;
    IMyTextSurface PowerDisplay;

    //Point declared Blocks to actual ingame objects.
    PowerStorage1 = GridTerminalSystem.GetBlockWithName("Battery 2") as IMyBatteryBlock;
    PowerStorage2 = GridTerminalSystem.GetBlockWithName("Battery 3") as IMyBatteryBlock;
    PowerDisplay = GridTerminalSystem.GetBlockWithName("PowerDisplay") as IMyTextSurface;
    
    //Get data values from the terminal for Blocks we declared.
    float PowerIn1 = PowerStorage1.CurrentInput;
    float PowerStored1 = PowerStorage1.CurrentStoredPower;
    float PowerIn2 = PowerStorage2.CurrentInput;
    float PowerStored2 = PowerStorage2.CurrentStoredPower;

    //Write Data values to an LCD display.
    PowerDisplay.WriteText("Battery1In " + PowerIn1.ToString() +
                                             "\nBattery2In " + PowerIn2.ToString() +
                                             "\nBattery1Stored " + PowerStored1.ToString() +
                                             "\nBattery2Stored " + PowerStored2.ToString());
}

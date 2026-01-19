// REDACTED SNIPPET: Equipment Abstraction Layer
// Demonstrates programmatic control of lab equipment for automated testing

public class FunctionGenerator : IEquipment
{
    private string _visaAddress;
    
    public void SetFrequency(double freqHz)
    {
        // Set frequency command
        SendCommand($"FREQ {freqHz}");
    }

    public void SetAmplitude(double vpp)
    {
        // Set amplitude command
        SendCommand($"VOLT {vpp}");
    }
    
    // ...
}

public class TestScenario_DAB_Stereo
{
    public void Run()
    {
        var generator = new FunctionGenerator();
        
        // Scenario: Speed dependent volume test
        // 80mph simulation
        generator.SetFrequency(1000); // 1kHz tone
        generator.SetAmplitude(1.0);
        
        // Verify system response...
    }
}
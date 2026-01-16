# Stratum Synthesizer (Assembly)

**Summary:** A hand-crafted audio synthesizer implemented largely in assembly with low-level drivers for speaker output, SD card access, SDRAM, and touchscreen I/O—focused on efficiency and driver-level control.

**Problem:** Produce a functional synthesizer on constrained embedded hardware with multiple instrument voices and low-latency control.

**Approach:** Implement synthesis routines and driver code in assembly for tight control over timing and memory; build drivers for SD I/O and speaker output.

**Results:** Full synthesizer with multiple instruments and a touchscreen interface; source demonstrates low-level driver work and audio path implementation.

Relevant files
- `Project Samples/Stratum Synthesizer (Assembly)/Code/speaker_driver.e`
- `.../sd_read_driver.e`, `sdram_read_driver.e`, `touchscreen_driver.e`, `synth` modules
- Written report and presentation in the root of the project folder.

Skills demonstrated
- Assembly-level optimization and hardware driver development
- Real-time audio signal generation and low-latency control
- Debugging constrained systems and interfacing with peripherals

Why this is relevant to Shure
- Shows low-level embedded audio engineering and driver development experience important for firmware that directly handles audio devices and peripheral interfaces.

## How to run / reproduce

- Hardware & toolchain: See `Stratum Written Report.pdf` for details on required hardware and the toolchain used in the course. The project was built and tested on the original target hardware described in the report.
- To run on target hardware:
  - Copy `combined.raw` to the root of an SD card used by the target board.
  - Load `test_top.e` (or `test_GUI.e` for interactive tests) as the main program using the course toolchain/toolchain loader.

## Downloads
- [Stratum Written Report (PDF)](../assets/stratum-synthesizer/Stratum Written Report.pdf){:target="_blank"}
- [Presentation (PPTX)](../assets/stratum-synthesizer/Stratum Presentation (download to avoid format issues).pptx){:target="_blank"}
- [Code (zip)](../assets/stratum-synthesizer/stratum-code.zip){:target="_blank"}

### What to inspect
- Read the **Stratum Written Report** for architecture and driver design notes.
- Inspect `speaker_driver.e` and the `synth` modules inside the code zip to see low-level driver logic and instrument synthesis routines.
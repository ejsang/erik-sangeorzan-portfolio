# Zumo Shield Robot Navigation (C)

**Summary:** STM32-based robot navigation project showing motor control, sensor IO, PWM, timers, and UART telemetry using the STM32 HAL and C.

Problem → Approach → Results
- Problem: Implement reliable line-following and navigation on a Zumo robot using the STM32 microcontroller.
- Approach: Use STM32 HAL to manage PWM motor control, GPIO sensors, timers and UART for debug telemetry; implement sensor scanning and corrective control logic in C.
- Results: Working line-following implementation with telemetry and documented firmware (`main.c`).

Relevant files
- `Project Samples/Zumo Shield Robot Navigation (C)/Line follower/main.c`

Skills demonstrated
- Embedded C programming on STM32 (PWM, timers, UART, GPIO)
- Low-level hardware control and real-time loop design for control systems
- Hardware debugging and interfacing with sensors and actuators

Why this is relevant to Shure
- Demonstrates embedded firmware development, hardware driver use and debugging—core skills for device firmware and low-level audio peripherals.

## How to run / reproduce

- Open the `Line follower` project in STM32CubeIDE (the project was created with STM32 Cube tools).
- Build and flash the firmware to the STM32 (Zumo) board.
- Open a serial console to the board (LPUART1 at **115200** baud) to view `printf` telemetry and debug messages.
- Verify motor and sensor wiring matches pins in `main.c`; adjust PWM/drive parameters as needed and test in a controlled environment.

## Downloads
- [Line follower code (zip)](../assets/zumo-shield-robot/zumo-line-follower.zip)

### What to inspect
- Open `main.c` in the zip and inspect the sensor scan and correction logic — this is where hardware timing and PWM control are implemented.
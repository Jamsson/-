use std::process::{Command, ExitStatus};
use std::thread;
use std::time::Duration;

fn main() {
    // Замените "notepad.exe" на путь к запускаемому приложению
    let program_to_run = "calc.exe";

    println!("Запуск калькулятора: {}", program_to_run);

    // Ожидание для того, чтобы калькулятор успел открыться
    thread::sleep(Duration::from_millis(0.001));

    loop{
        let status: ExitStatus = Command::new(program_to_run)
          .spawn()
          .expect("Ошибка при запуске приложения")
          .wait()
          .expect("Ошибка при ожидании завершения приложения");

        if status.success() {
           println!("Приложение успешно запущено!");
        } else {
           println!("Приложение завершилось с ошибкой.");
        }
    }

    // Добавьте дополнительное ожидание, чтобы консоль не закрывалась моментально
    thread::sleep(Duration::from_secs(500));
}

use rand::Rng;
use std::cmp::Ordering;
use std::io;

fn main() {
    println!("Угадай число!");

    let secret_number = rand::thread_rng().gen_range(1..101);

    loop {
        println!("Пожалуйста, введите ваше предположение.");

        let mut guess = String::new();

        io::stdin()
            .read_line(&mut guess)
            .expect("Не удалось прочитать строку");

        let guess: u32 = match guess.trim().parse() {
            Ok(num) => num,
            Err(_) => continue,
        };

        println!("В написали: {guess}");

        match guess.cmp(&secret_number) {
            Ordering::Less => println!("Слишком маленький!"),
            Ordering::Greater => println!("Слишком большой!"),
            Ordering::Equal => println!("Ты победил!"),
        }
    }
}
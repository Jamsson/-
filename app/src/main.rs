use std::io;
use rand::Rng;

fn main() {
    println!("Введите размер массива:");

    let mut n = String::new();

    io::stdin()
        .read_line(&mut n)
        .expect("Ошибка ввода");

    let n: usize = n.trim().parse().expect("Размер массива должен быть числом");

    let mut a = Vec::new();
    let mut rng = rand::thread_rng();

    for _ in 0..n {
        a.push(rng.gen_range(1..51));
    }

    println!("Введите индекс массива:");

    let mut index = String::new();

    io::stdin()
        .read_line(&mut index)
        .expect("Ошибка ввода");

    let index: usize = index.trim().parse().expect("Введенный индекс не является числом");

    if let Some(element) = a.get(index) {
        println!("В индексе под номером {} находится число: {}", index, element);
    } else {
        println!("Индекс вне диапазона массива");
    }
}

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MortalKombatTest
{
    public partial class MainWindow : Window
    {
        private Test _test;
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            List<Question> questions = new List<Question>
            {
                new Question("1992 год. Выходит первая часть Mortal Kombat. " +
                             "По сюжету вам нужно сразиться в жестоком турнире " +
                             "под названием «Смертельная битва». Как зовут " +
                             "организатора и главного босса?",
                    new List<string>{"Шан Цзун", "Шао Кан", "Шан Као Цзун"}),
                new Question("1993 год. Во второй части Mortal Kombat Шан Цзун терпит " +
                             "поражение от Лю Кана, затем просит своего повелителя " +
                             "Шао Кана сохранить ему жизнь и предлагает план захвата " +
                             "Земного царства. Здесь же мы встречаем новых персонажей. " +
                             "Например, Джакса. Вспомните, кто он?",
                    new List<string>{"Он из спецназа США", "Бывший космонавт", 
                        "Чемпион по американскому футболу", "Тренер по фитнесу"}),
                new Question("В 1995 году выходит легендарная Mortal Kombat 3. " +
                             "В ней много нововведений. Например, игрокам дают " +
                             "возможность бегать, выбрасывать противников на " +
                             "другую арену, добавляют финальное комбо. Какое?",
                    new List<string>{"Animality", "Babality", "Friendship", "Fatality"}),
                new Question("Вслед за игрой в 1995 году снимают фильм «Смертельная битва» " +
                             "по мотивам игры Mortal Kombat. Кого из персонажей игры нет в фильме?",
                    new List<string>{"Шиннок", "Лю Кан", "Соня Блейд", "Китана"}),
                new Question("В сентябре 1997 года на PlayStation и на ПК выходит Mortal Kombat 4. " +
                             "Что становится главным дополнением в этой части?",
                    new List<string>{"Возможность использовать оружие, разбросанное по арене", 
                        "Экран «Choose your Destiny», позволяющий выбрать противников", 
                        "Возможность использовать Fatality, а потом сразу Brutality", 
                        "Восточная тема в игре"}),
                new Question("И вот мы уже в 2011 году. Выходит Mortal Kombat 9, которая " +
                             "представляет собой одновременно продолжение и перезагрузку франшизы. " +
                             "Кто из новых персонажей появляется в этой части?",
                    new List<string>{"Фредди Крюгер", "Ночной Волк", "Джейсон Вурхиз", "Кожаное Лицо"}),
                new Question("2015 год. Выходит десятая часть в серии файтингов — Mortal Kombat Х " +
                             "(произносится как «Мортал Комбат Икс»). Сильно меняется геймплей, " +
                             "появляются восемь новых персонажей, игра становится доступна на Android и iOS. " +
                             "И впервые в истории Mortal Kombat охватывает большой промежуток времени. " +
                             "Сколько лет длится эта битва по сюжету?",
                    new List<string>{"25 лет", "5 лет", "99 лет", "300 лет"}),

            };
            _test = new Test(questions);
            _test.NextQuestion();
            UpdateUi();
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
            StartButton.IsEnabled = false;
            StartButton.Visibility = Visibility.Collapsed;
            NextButton.IsEnabled = true;
            FinishButton.IsEnabled = true;
        }

        private void UpdateUi()
        {
            QuestionText.Text = _test.CurrentQuestion.QuestionText;
            AnswerList.ItemsSource = _test.CurrentQuestion.Answers;
            ScoreText.Text = $"Очки: {_test.Score}";
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            var answer = (sender as Button)?.Content.ToString();
            _test.CheckAnswer(answer);
            if (_test.IsFinished)
            {
                Finish();
            }
            else
            {
                _test.NextQuestion();
                UpdateUi();
            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            _test.NextQuestion();
            UpdateUi();
        }
        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            Finish();
        }
        private void Finish()
        {
            _timer.Stop();
            MessageBox.Show($@"Тест завершен! Количество очков: {_test.Score} {Environment.NewLine}Время: {_test.TimeElapsed:mm\:ss}");
            Close();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _test.TimeElapsed += TimeSpan.FromSeconds(1);
            TimeText.Text = $@"Время: {_test.TimeElapsed:mm\:ss}";
        }
    }
}

public class Test
{
    private readonly List<Question> _questions;
    private int _currentQuestionIndex;

    public Test(List<Question> questions)
    {
        _questions = questions;
        _currentQuestionIndex = -1;
        Score = 0;
        TimeElapsed = TimeSpan.Zero;
        IsFinished = false;
    }

    public Question CurrentQuestion => _questions[_currentQuestionIndex];
    public int Score { get; private set; }
    public TimeSpan TimeElapsed { get; set; }
    public bool IsFinished { get; private set; }

    public void NextQuestion()
    {
        if (_currentQuestionIndex < _questions.Count - 1)
        {
            _currentQuestionIndex++;
        }
        else
        {
            IsFinished = true;
        }
    }

    public void CheckAnswer(string answer)
    {
        if (CurrentQuestion.IsCorrect(answer))
        {
            Score++;
        }
    }
}

public class Question
{
    public string QuestionText { get; }
    public List<string> Answers { get; }
    public string CorrectAnswer { get; }

    public Question(string questionText, List<string> answers)
    {
        QuestionText = questionText;
        Answers = answers;
        CorrectAnswer = Answers[0]; // верный ответ
    }

    public bool IsCorrect(string answer)
    {
        return answer == CorrectAnswer;
    }
}
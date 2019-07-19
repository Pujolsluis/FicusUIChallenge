using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace FicusUIChallenge.Helpers.Behaviors
{
    public class ViewTappedButtonBehavior : BehaviorBase<View>
    {
        public event EventHandler Clicked;

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ViewTappedButtonBehavior), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ViewTappedButtonBehavior), null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        protected override void OnAttachedTo(View bindable)
        {
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += View_Tapped;
            bindable.GestureRecognizers.Add(tapGestureRecognizer);
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(View bindable)
        {
            var exists = bindable.GestureRecognizers.FirstOrDefault() as TapGestureRecognizer;

            if (exists != null)
                exists.Tapped -= View_Tapped;

            base.OnDetachingFrom(bindable);
        }

        bool _isAnimating = false;

        void View_Tapped(object sender, EventArgs e)
        {
            if (_isAnimating)
                return;

            _isAnimating = true;

            var view = (View)sender;

            Device.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    await view.FadeTo(0.3, 300);
                    await view.FadeTo(1, 300);
                }
                finally
                {
                    Clicked?.Invoke(this, EventArgs.Empty);

                    if (Command != null)
                    {
                        if (Command.CanExecute(CommandParameter))
                        {
                            Command.Execute(CommandParameter);
                        }
                    }
                    System.Diagnostics.Debug.WriteLine(CommandParameter);

                    _isAnimating = false;
                }
            });
        }
    }
}

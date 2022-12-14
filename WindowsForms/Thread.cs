        bool threadRunning = true;
        public start()
        {
            //Starting background Thread
            Thread thread = new Thread(backgroundTask);
            thread.SetApartmentState(ApartmentState.STA);
            CheckForIllegalCrossThreadCalls = false;
            thread.Start();
        }

        async void backgroundTask()
        {
            while (threadRunning)
            {
                Thread.Sleep(49);//Minimum CPU usage                
            }
        }

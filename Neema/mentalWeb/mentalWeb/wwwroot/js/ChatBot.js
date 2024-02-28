// Place the JavaScript code from the <script> tag here
$(function () {
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>

    <script type="text/javascript">
        const imgBOT = "/images/bot.png";
        const imgPerson = "/images/user.png";
        const nameBOT = "ChatGPT";
        const namePerson = "Srinivas";

        $(function () {
            addChatMessage(nameBOT, imgBOT, "right", "Hey! How may I help you?");

            $('#sendButton').click(function () {
                var message = $('#messageInput').val();
                askChatGPT(message);
                $('#messageInput').val('');
                return false;
            });

            function askChatGPT(message) {
                addChatMessage(namePerson, imgPerson, "left", message);

                $.ajax({
                    url: '/AskChatGPT',
                    type: 'POST',
                    data: JSON.stringify(message),
                    async: true,
                    contentType: 'application/json',
                    success: function (response) {
                        addChatMessage(nameBOT, imgBOT, "right", response.data);
                        $('.imgLoader').hide();
                    }
                });
            }

            function addChatMessage(name, img, side, text) {
                const msgHTML = `
                                <div class="msg ${side}-msg">
                                    <div class="msg-img" style="background-image: url(${img})"></div>

                                    <div class="msg-bubble">
                                    <div class="msg-info">
                                        <div class="msg-info-name">${name}</div>
                                        <div class="msg-info-time">${formatDate(new Date())}</div>
                                    </div>

                                    <div class="msg-text">${text}</div>
                                    </div>
                                </div>
                                `;

                $(".msger-chat").append($(msgHTML));

                if (side == "left") {
                    var loaderHTML = `<div id="dvLoader"><img class="imgLoader" src="/images/loader.gif" /></div>`;
                    $(".msger-chat").append($(loaderHTML));
                }

                $(".msger-chat").scrollTop($(".msger-chat").scrollTop() + 500);

                return false;
            }

            function formatDate(date) {
                const h = "0" + date.getHours();
                const m = "0" + date.getMinutes();

                return `${h.slice(-2)}:${m.slice(-2)}`;
            }
        });
    </script>
});


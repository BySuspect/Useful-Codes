
///Not working

    public class InviteBase
    {
        public string code { get; set; }
        public Guild? guild { get; set; }
        public Channel? channel { get; set; }
        public User? inviter { get; set; }
        public int? target_type { get; set; }
        public User? target_user { get; set; }
        public Application? target_application { get; set; }
        public int? approximate_presence_count { get; set; }
        public int? approximate_member_count { get; set; }
        public DateTime? expires_at { get; set; }
        public InviteStageInstance? stage_instance { get; set; } // deprecated
        public GuildScheduledEvent? guild_scheduled_event { get; set; }
    }
    public class Guild
    {
        public ulong id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string icon_hash { get; set; }
        public string splash { get; set; }
        public string discovery_splash { get; set; }
        public bool? owner { get; set; }
        public ulong owner_id { get; set; }
        public string permissions { get; set; }
        public string region { get; set; }
        public ulong afk_channel_id { get; set; }
        public int afk_timeout { get; set; }
        public bool? widget_enabled { get; set; }
        public ulong widget_channel_id { get; set; }
        public int verification_level { get; set; }
        public int default_message_notifications { get; set; }
        public int explicit_content_filter { get; set; }
        public List<Role> roles { get; set; }
        public List<Emoji> emojis { get; set; }
        public List<GuildFeatures> features { get; set; }
        public int mfa_level { get; set; }
        public ulong application_id { get; set; }
        public ulong system_channel_id { get; set; }
        public int system_channel_flags { get; set; }
        public ulong rules_channel_id { get; set; }
        public int? max_presences { get; set; }
        public int max_members { get; set; }
        public string vanity_url_code { get; set; }
        public string description { get; set; }
        public string banner { get; set; }
        public int premium_tier { get; set; }
        public int? premium_subscription_count { get; set; }
        public string preferred_locale { get; set; }
        public ulong public_updates_channel_id { get; set; }
        public int max_video_channel_users { get; set; }
        public int max_stage_video_channel_users { get; set; }
        public int approximate_member_count { get; set; }
        public int approximate_presence_count { get; set; }
        public WelcomeScreen welcome_screen { get; set; }
        public int nsfw_level { get; set; }
        public List<Sticker> stickers { get; set; }
        public bool premium_progress_bar_enabled { get; set; }
    }
    public class WelcomeScreen
    {
        public string? description { get; set; }
        public List<WelcomeScreenChannel> welcome_channels { get; set; }
    }
    public class WelcomeScreenChannel
    {
        public ulong channel_id { get; set; }
        public string description { get; set; }
        public ulong? emoji_id { get; set; }
        public string? emoji_name { get; set; }
    }
    public class Sticker
    {
        public ulong id { get; set; }
        public ulong? pack_id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public string tags { get; set; }
        public string? asset { get; set; }
        public int type { get; set; }
        public int format_type { get; set; }
        public bool? available { get; set; }
        public ulong? guild_id { get; set; }
        public User user { get; set; }
        public int? sort_value { get; set; }
    }
    public class GuildFeatures
    {
        public object ANIMATED_BANNER { get; set; }
        public object ANIMATED_ICON { get; set; }
        public object APPLICATION_COMMAND_PERMISSIONS_V2 { get; set; }
        public object AUTO_MODERATION { get; set; }
        public object BANNER { get; set; }
        public object COMMUNITY { get; set; }
        public object CREATOR_MONETIZABLE_PROVISIONAL { get; set; }
        public object CREATOR_STORE_PAGE { get; set; }
        public object DEVELOPER_SUPPORT_SERVER { get; set; }
        public object DISCOVERABLE { get; set; }
        public object FEATURABLE { get; set; }
        public object INVITES_DISABLED { get; set; }
        public object INVITE_SPLASH { get; set; }
        public object MEMBER_VERIFICATION_GATE_ENABLED { get; set; }
        public object MORE_STICKERS { get; set; }
        public object NEWS { get; set; }
        public object PARTNERED { get; set; }
        public object PREVIEW_ENABLED { get; set; }
        public object ROLE_ICONS { get; set; }
        public object ROLE_SUBSCRIPTIONS_AVAILABLE_FOR_PURCHASE { get; set; }
        public object ROLE_SUBSCRIPTIONS_ENABLED { get; set; }
        public object TICKETED_EVENTS_ENABLED { get; set; }
        public object VANITY_URL { get; set; }
        public object VERIFIED { get; set; }
        public object VIP_REGIONS { get; set; }
        public object WELCOME_SCREEN_ENABLED { get; set; }
    }
    public class Emoji
    {
        public ulong? id { get; set; }
        public string name { get; set; }
        public ulong[] roles { get; set; }
        public User user { get; set; }
        public bool require_colons { get; set; }
        public bool managed { get; set; }
        public bool animated { get; set; }
        public bool available { get; set; }
    }
    public class Role
    {
        public ulong id { get; set; }
        public string name { get; set; }
        public int color { get; set; }
        public bool hoist { get; set; }
        public string icon { get; set; }
        public string unicode_emoji { get; set; }
        public int position { get; set; }
        public string permissions { get; set; }
        public bool managed { get; set; }
        public bool mentionable { get; set; }
        public RoleTags tags { get; set; }
    }
    public class RoleTags
    {
        public ulong? bot_id { get; set; }
        public ulong? integration_id { get; set; }
        public bool? premium_subscriber { get; set; }
        public ulong? subscription_listing_id { get; set; }
        public bool? available_for_purchase { get; set; }
        public bool? guild_connections { get; set; }
    }
    public class Channel
    {
        public ulong id { get; set; }
        public int type { get; set; }
        public ulong? guild_id { get; set; }
        public int? position { get; set; }
        public List<Overwrite> permission_overwrites { get; set; }
        public string? name { get; set; }
        public string? topic { get; set; }
        public bool nsfw { get; set; }
        public ulong? last_message_id { get; set; }
        public int? bitrate { get; set; }
        public int? user_limit { get; set; }
        public int? rate_limit_per_user { get; set; }
        public List<User> recipients { get; set; }
        public string? icon { get; set; }
        public ulong? owner_id { get; set; }
        public ulong? application_id { get; set; }
        public bool managed { get; set; }
        public ulong? parent_id { get; set; }
        public DateTimeOffset? last_pin_timestamp { get; set; }
        public string? rtc_region { get; set; }
        public int video_quality_mode { get; set; }
        public int? message_count { get; set; }
        public int member_count { get; set; }
        public ThreadMetadata thread_metadata { get; set; }
        public ThreadMember member { get; set; }
        public int default_auto_archive_duration { get; set; }
        public string? permissions { get; set; }
        public int flags { get; set; }
        public int total_message_sent { get; set; }
        public List<Tag> available_tags { get; set; }
        public List<ulong> applied_tags { get; set; }
        public DefaultReaction default_reaction_emoji { get; set; }
        public int default_thread_rate_limit_per_user { get; set; }
        public int? default_sort_order { get; set; }
        public int default_forum_layout { get; set; }
    }
    public class Overwrite
    {
        public ulong Id { get; set; }
        public int Type { get; set; }
        public string Allow { get; set; }
        public string Deny { get; set; }
    }
    public class ThreadMetadata
    {
        public bool Archived { get; set; }
        public int AutoArchiveDuration { get; set; }
        public DateTime ArchiveTimestamp { get; set; }
        public bool Locked { get; set; }
        public bool Invitable { get; set; }
        public DateTime? CreateTimestamp { get; set; }
    }
    public class ThreadMember
    {
        public ulong? Id { get; set; }
        public ulong? UserId { get; set; }
        public DateTimeOffset JoinTimestamp { get; set; }
        public int Flags { get; set; }
        public GuildMember Member { get; set; }
    }
    public class GuildMember
    {
        public User user { get; set; }
        public string nick { get; set; }
        public string avatar { get; set; }
        public List<ulong> roles { get; set; }
        public DateTime joined_at { get; set; }
        public DateTime? premium_since { get; set; }
        public bool deaf { get; set; }
        public bool mute { get; set; }
        public int flags { get; set; }
        public bool? pending { get; set; }
        public string permissions { get; set; }
        public DateTime? communication_disabled_until { get; set; }
    }
    public class Tag
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public bool Moderated { get; set; }
        public ulong? EmojiId { get; set; }
        public string EmojiName { get; set; }
    }
    public class DefaultReaction
    {
        public ulong? EmojiId { get; set; }
        public string EmojiName { get; set; }
    }
    public class User
    {
        public ulong id { get; set; }
        public string username { get; set; }
        public string discriminator { get; set; }
        public string avatar { get; set; }
        public bool? bot { get; set; }
        public bool? system { get; set; }
        public bool? mfa_enabled { get; set; }
        public string banner { get; set; }
        public int? accent_color { get; set; }
        public string locale { get; set; }
        public bool? verified { get; set; }
        public string email { get; set; }
        public int? flags { get; set; }
        public int? premium_type { get; set; }
        public int? public_flags { get; set; }
    }
    public class Application
    {
        public ulong id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
        public string[] rpc_origins { get; set; }
        public bool bot_public { get; set; }
        public bool bot_require_code_grant { get; set; }
        public string terms_of_service_url { get; set; }
        public string privacy_policy_url { get; set; }
        public User owner { get; set; }
        [Obsolete("Deprecated and will be removed in v11. An empty string.")]
        public string? summary { get; set; }
        public string verify_key { get; set; }
        public Team team { get; set; }
        public ulong guild_id { get; set; }
        public ulong primary_sku_id { get; set; }
        public string slug { get; set; }
        public string cover_image { get; set; }
        public int flags { get; set; }
        public string[] tags { get; set; }
        public InstallParams install_params { get; set; }
        public string custom_install_url { get; set; }
        public string role_connections_verification_url { get; set; }
    }
    public class Team
    {
        public string Icon { get; set; }
        public ulong Id { get; set; }
        public IEnumerable<TeamMember> Members { get; set; }
        public string Name { get; set; }
        public ulong OwnerUserId { get; set; }
    }
    public class TeamMember
    {
        public int MembershipState { get; set; }
        public IEnumerable<string> Permissions { get; set; }
        public ulong TeamId { get; set; }
        public User User { get; set; }
    }
    public class InstallParams
    {
        public string[] Scopes { get; set; }
        public string Permissions { get; set; }
    }
    public class InviteStageInstance
    {
        public List<GuildMember> Members { get; set; }
        public int ParticipantCount { get; set; }
        public int SpeakerCount { get; set; }
        public string Topic { get; set; }
    }
    public class GuildScheduledEvent
    {
        public ulong id { get; set; }
        public ulong guild_id { get; set; }
        public ulong? channel_id { get; set; }
        public ulong? creator_id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public DateTimeOffset scheduled_start_time { get; set; }
        public DateTimeOffset? scheduled_end_time { get; set; }
        public object? privacy_level { get; set; }
        public object? status { get; set; }
        public object? entity_type { get; set; }
        public ulong? entity_id { get; set; }
        public EntityMetadata? entity_metadata { get; set; }
        public User? creator { get; set; }
        public int? user_count { get; set; }
        public string? image { get; set; }
    }
    public class EntityMetadata
    {
        public string? location { get; set; }
    }

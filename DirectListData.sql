USE [DirectListDb]
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Image], [Name], [Title], [CreatedDate]) VALUES (1, N'ddc0cbb1-08f4-411d-9695-19c55383af84-20220103004552-bg-cs.jpg', N'Take a Look at Hotels for All Budgets', N'Take a Look at Hotels for All Budgets', CAST(N'2021-12-31T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Image], [Name], [Title], [CreatedDate]) VALUES (2, N'22c13ab9-4b8c-408d-8fb1-f3cf39152b2f-20220103004634-most-img-1.jpg', N'The Best Cofee Shops In Sydney Neighborhoods', N'The Best Cofee Shops In Sydney Neighborhoods', CAST(N'2022-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Image], [Name], [Title], [CreatedDate]) VALUES (3, N'd1b84c71-0d4e-4319-994b-d917b20b911b-20220103004713-post-2.jpg', N'The 50 Greatest Street Arts In London', N'The 50 Greatest Street Arts In London', CAST(N'2021-01-02T12:22:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [BlogId]) VALUES (1, N'wd', N'dawd', N'wda', N'dawda', CAST(N'2022-01-03T12:50:44.3824291' AS DateTime2), 1)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [BlogId]) VALUES (2, N'awdadawopjih', N'iuyvu', N'bknutkvu,jb', N'uvybhjkj
wd', CAST(N'2022-01-03T12:52:28.8587631' AS DateTime2), 1)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [BlogId]) VALUES (3, N'Kane', N'dnakdw', N'nwiiakd', N'dnwakd', CAST(N'2022-01-03T14:15:09.7662390' AS DateTime2), 3)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [BlogId]) VALUES (4, N'Jane', N'jane@gmail.com', N'sdfg', N'asdf
', CAST(N'2022-01-03T20:25:26.4736617' AS DateTime2), 3)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [BlogId]) VALUES (5, N'Jane', N'awdvhb', N'gfcxdrextyv', N'cfuytvubhj', CAST(N'2022-01-03T20:25:43.9573867' AS DateTime2), 2)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Name]) VALUES (3, N'SWIMMING POOL')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (4, N'FREE WIFI INTERNET ACCESS INCLUDED')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (5, N'FREE PARKING')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (6, N'SWIMMINGPOOL OUTDOOR')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (7, N'FAMILY ROOMS')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (8, N'NON SMOKING ROOMS')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (9, N'awdawdw')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [AddressLocation], [CreatedDate], [LocationNote], [Website], [Image]) VALUES (1, N'Tom House', N'4340 Cambridge Court Natural', N'Dam, Arkansas', N'+123 123 456 45', N'+2345678', N'+765432217', CAST(N'2022-01-04T10:00:00.0000000' AS DateTime2), CAST(N'2022-01-04T21:00:00.0000000' AS DateTime2), N'Dingloy Place, Remington, London, EC1V 8BP, United Kingdom', CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', N'admin.com', N'dp-3.jpg')
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [AddressLocation], [CreatedDate], [LocationNote], [Website], [Image]) VALUES (3, N'Burger House', N'1314 sffe fees', N'sefesfse e', N'+3234567', N'+123456789', N'+34234768', CAST(N'2022-01-04T10:00:00.0000000' AS DateTime2), CAST(N'2022-01-04T18:00:00.0000000' AS DateTime2), N'ad', CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), N'awD', N'restaurant.com', N'dp-4.jpg')
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [AddressLocation], [CreatedDate], [LocationNote], [Website], [Image]) VALUES (4, N'Victoria House', N'456 Lorem dabiwu', N'awodoywbad,dawubaw', N'+978', N'+12345', N'+098w983', CAST(N'2022-01-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-01-05T06:00:00.0000000' AS DateTime2), N'Jabdiwun', CAST(N'2022-01-05T00:00:00.0000000' AS DateTime2), N'Kawudyia', N'house.com', N'dp-5.jpg')
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantToFeatures] ON 

INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (1, 1, 6)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (2, 1, 9)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (4, 1, 3)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (6, 3, 9)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (7, 3, 8)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (8, 3, 7)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (9, 3, 6)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (10, 3, 5)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (11, 4, 3)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (12, 4, 5)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (13, 4, 7)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (14, 4, 8)
SET IDENTITY_INSERT [dbo].[RestaurantToFeatures] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (1, N'Classic Burger', N'Beef, salad, mayonnaise, spicey relish, cheese')
INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (2, N'Cheddar Burger', N'Cheddar cheese, lettuce, tomato, onion, dill pickles')
INSERT [dbo].[Menus] ([Id], [Name], [Ingredient]) VALUES (3, N'Chicken Burger', N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil')
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantToMenus] ON 

INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (1, CAST(4.00 AS Decimal(18, 2)), 1, 2)
INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (4, CAST(8.00 AS Decimal(18, 2)), 3, 3)
INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (6, CAST(10.00 AS Decimal(18, 2)), 3, 1)
INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (7, CAST(2.00 AS Decimal(18, 2)), 1, 3)
INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (9, CAST(12.00 AS Decimal(18, 2)), 4, 1)
INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (11, CAST(8.50 AS Decimal(18, 2)), 4, 2)
INSERT [dbo].[RestaurantToMenus] ([Id], [Price], [RestaurantId], [MenuId]) VALUES (12, CAST(3.90 AS Decimal(18, 2)), 4, 3)
SET IDENTITY_INSERT [dbo].[RestaurantToMenus] OFF
GO
SET IDENTITY_INSERT [dbo].[Adminstrator] ON 

INSERT [dbo].[Adminstrator] ([Id], [Name], [Phone], [Email], [Image], [RestaurantId]) VALUES (1, N'Victoria', N'+3456654321', N'victoria@gmail.com', N'thumb-1.jpg', 1)
INSERT [dbo].[Adminstrator] ([Id], [Name], [Phone], [Email], [Image], [RestaurantId]) VALUES (2, N'Benson', N'+34874328', N'benson@gmail.com', N'thumb-2.jpg', 3)
SET IDENTITY_INSERT [dbo].[Adminstrator] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantReviews] ON 

INSERT [dbo].[RestaurantReviews] ([Id], [FullName], [Content], [CreatedDate], [RestaurantId]) VALUES (1, N'Ava', N'fghjhdgfc', CAST(N'2022-01-04T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[RestaurantReviews] ([Id], [FullName], [Content], [CreatedDate], [RestaurantId]) VALUES (5, N'Avaad', N'fghjhdgfcawdawda', CAST(N'2022-01-04T19:15:19.4321831' AS DateTime2), 1)
INSERT [dbo].[RestaurantReviews] ([Id], [FullName], [Content], [CreatedDate], [RestaurantId]) VALUES (6, N'awd', N'fghjhdgfc', CAST(N'2022-01-05T13:32:00.8375039' AS DateTime2), 3)
INSERT [dbo].[RestaurantReviews] ([Id], [FullName], [Content], [CreatedDate], [RestaurantId]) VALUES (7, N'xerdctfvygbuhnij', N'ehbosyiucls', CAST(N'2022-01-05T13:32:43.5749743' AS DateTime2), 3)
INSERT [dbo].[RestaurantReviews] ([Id], [FullName], [Content], [CreatedDate], [RestaurantId]) VALUES (8, N'h3ragF3R', N'fghjhdgfcf33RF3fr3RF3rfqRFq3', CAST(N'2022-01-05T13:38:39.5762709' AS DateTime2), 3)
SET IDENTITY_INSERT [dbo].[RestaurantReviews] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'DINNER')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'SEA FOOD')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (4, N'HOTEL')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantToTags] ON 

INSERT [dbo].[RestaurantToTags] ([Id], [RestaurantId], [TagId]) VALUES (1, 1, 3)
INSERT [dbo].[RestaurantToTags] ([Id], [RestaurantId], [TagId]) VALUES (2, 1, 4)
INSERT [dbo].[RestaurantToTags] ([Id], [RestaurantId], [TagId]) VALUES (5, 3, 1)
INSERT [dbo].[RestaurantToTags] ([Id], [RestaurantId], [TagId]) VALUES (6, 3, 4)
INSERT [dbo].[RestaurantToTags] ([Id], [RestaurantId], [TagId]) VALUES (8, 4, 1)
INSERT [dbo].[RestaurantToTags] ([Id], [RestaurantId], [TagId]) VALUES (9, 4, 3)
SET IDENTITY_INSERT [dbo].[RestaurantToTags] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Image], [Name], [Title]) VALUES (N'63485f54-2f3a-4061-900c-7cf3f9ca1a78', N'punhanash@code.edu.az', N'PUNHANASH@CODE.EDU.AZ', N'punhanash@code.edu.az', N'PUNHANASH@CODE.EDU.AZ', 0, N'AQAAAAEAACcQAAAAECIed6+XHc2wPQK0r7eF2HdEbV9onNYs6xR+f2YVkKvWF2ibMFSmQnM3nyXCV6r5RA==', N'AMYT66GU572K4456OZT4MT2CUJ4YF3LH', N'1b225967-ad4e-428d-9f1d-0c43ce705c1c', NULL, 0, 0, NULL, 1, 0, N'CustomUser', N'blank-profile-picture-973460_960_720', N'Punhan', N'resweydruftigyhupiojnblvgcjtxderywtsrydtfigyuhi')
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Image], [Title], [SubTitle]) VALUES (1, N'fb56e2d2-16c7-479e-a7e0-2189f455f893-20220102171131-most-img-2.jpg', N'Our Goal12', N'Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel consectetur, ipsa autem vitae quos ea laborum expedita')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (1, N'b64619b3-639c-43d0-b70a-31ff09f1f508-20220104110616-title-bar.jpg', N'Blogs', N'Explore Blogs', N'List of Blogs')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (5, N'51a5da17-7466-40c0-968b-38a71147434e-20220104110700-title-bar.jpg', N'Contact', N'Explore Contact', N'Contact')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (6, N'b2ad87cd-0d15-47fc-aba5-df8f36be6823-20220104110710-title-bar.jpg', N'About', N'Explore About', N'About')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (7, N'4f38c6cc-79ae-4c57-9ae2-4dd2868bfd1c-20220104150358-title-bar.jpg', N'Restaurants', N'Explore Restaurants', N'Restaurant')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (8, N'b6aaf7d0-090f-49ed-9f4e-9713ad740fa2-20220104110744-title-bar.jpg', N'Blog', N'Explore Selected Blog', N'Detail of Blog')
INSERT [dbo].[Banners] ([Id], [Image], [Title], [SubTitle], [Page]) VALUES (9, N'20b2a7d1-11a8-4be7-8a00-0ad041ac1b20-20220104150338-title-bar.jpg', N'Restaurant', N'Explore Restaurant', N'Detail of Restaurant')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (1, N'Punhan', N'Shahmurov', N'punhanash@code.edu.az', N'ASDF', N'ASDF', CAST(N'2022-01-03T19:25:33.3042011' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (4, N'Sahib', N'Sahib', N'sahibaa@code.edu.az', N'ASDF', N'asfds', CAST(N'2022-01-03T22:31:57.3007863' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [ContactAddress], [ContactEmail], [ContactPhone], [Address], [Email], [Phone], [AboutUs], [DreamTitle], [DreamSubTitle]) VALUES (1, N'c6e96098-18df-410c-90e7-25758016ded1-20220104105552-logo-white.png', N'12', N'12edad', N'edcad', N'12345 Little Lonsdale St, Melbourne', N'office@example.com', N'(123) 123-456', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem sapiente, fugiat commodi reprehenderit expedita nam nemo</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!</p>', N'Plan The Vacation of Yourgrsf Dreams', N'Explore some of the best tips from around the world from our partners and friends. Discover some of the most popular listings in Sydney grterfased.')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (1, N'fab fa-facebook', N'Facebook', N'facebook.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (2, N'fab fa-instagram', N'Instagram', N'instagram.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Name], [Link]) VALUES (3, N'fab fa-twitter', N'Twitter', N'twitter.com')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
